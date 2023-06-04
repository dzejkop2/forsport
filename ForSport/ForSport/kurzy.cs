using ForSport.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ForSport
{
    public partial class kurzy : Form
    {
        List<Odds> odds_list = new List<Odds>();
        public kurzy()
        {
            InitializeComponent();
            get_odds();
            foreach (Odds odd in odds_list)
            {
                odd.create_odd();
            }
        }
        private void get_odds()
        {
            int pos = 0;
            string sql = $"SELECT * FROM kurzy ORDER BY date ASC";
            MySqlCommand command = new MySqlCommand(sql, Database.connection);
            MySqlDataReader reader = command.ExecuteReader();

            if (!reader.HasRows)
            {
                reader.Close();
                return;
            }
            while (reader.Read())
            {
                odds_list.Add(new Odds(panel_main, pos, reader.GetString("first_team"), reader.GetString("second_team"), reader.GetString("date"), reader.GetString("kurz1"), reader.GetString("kurz10"), reader.GetString("kurz0"), reader.GetString("kurz02"), reader.GetString("kurz2")));
                pos = pos + 100;
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Button btn_skuska = new Button();
            btn_skuska.BackColor = Color.Black;
            btn_skuska.Enabled = false;
            btn_skuska.Text = "SKUSKA";
            btn_skuska.Location = new Point(0, 0);
            btn_skuska.Size = new Size(500, 500);
            btn_skuska.BringToFront();
            this.Controls.Add(btn_skuska);*/
            
        }
        private void deal_event(string meno, string kurz)
        {

            string[] rozdelenie = meno.Split(',');
            lb_vysledok.Text = $"{rozdelenie[0]} + {rozdelenie[2]}";
           switch (rozdelenie[2])
            {
                case "kurz1": lb_vysledok.Text = $"{rozdelenie[0]} vyhra"; break;
                case "kurz10": lb_vysledok.Text = $"{rozdelenie[0]} neprehra"; break;
                case "kurz0": lb_vysledok.Text = $"Remíza"; break;
                case "kurz02": lb_vysledok.Text = $"{rozdelenie[1]} neprehra2"; break;
                case "kurz2": lb_vysledok.Text = $"{rozdelenie[1]} vyhra2"; break;
                default: lb_vysledok.Text = $"nefunguje{rozdelenie[0]}"; break;
                
            }
            lb_kurzvysledok.Text= kurz;
            
        }
        private void load_btn_events()
        {
            string tymy = "";
            foreach (Panel panel_tmp in panel_main.Controls.OfType<Panel>())
            {
                
                foreach (Button item in panel_tmp.Controls.OfType<Button>())
                {
                    
                    item.Click += (s, e) => { deal_event(item.Name, item.Text); };
                }
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            load_btn_events();
        }
    }
}