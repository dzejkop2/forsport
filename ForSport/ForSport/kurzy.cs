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
        private string id;
        public float balance;
        app appka;
        public kurzy(string id, float balance, app appka)
        {
            
            InitializeComponent();
            bt_stavit.FlatAppearance.BorderSize = 0;
            this.id = id;
            this.balance = balance;
            this.appka = appka;
            
            get_odds();
            foreach (Odds odd in odds_list)
            {
                odd.create_odd();
            }
            load_btn_events();
            
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
            
            
        }
        private void deal_event(string meno, string kurz)
        {

            string[] rozdelenie = meno.Split(',');
            lb_vysledok.Text = $"{rozdelenie[0]} + {rozdelenie[2]}";
           switch (rozdelenie[2])
            {
                case "kurz1": lb_vysledok.Text = $"{rozdelenie[0]} vyhrá"; break;
                case "kurz10": lb_vysledok.Text = $"{rozdelenie[0]} neprehrá"; break;
                case "kurz0": lb_vysledok.Text = $"{rozdelenie[0]} remíza"; break;
                case "kurz02": lb_vysledok.Text = $"{rozdelenie[1]} neprehrá2"; break;
                case "kurz2": lb_vysledok.Text = $"{rozdelenie[1]} vyhrá2"; break;
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

        private void bt_stavit_Click(object sender, EventArgs e)
        {
            if(tb_vklad.Text.Trim() != string.Empty)
            {
                
                string[] vysledok = new string[2];
                double result = 0;
                string vklad = tb_vklad.Text.Replace(".", ",");
                string kurz = lb_kurzvysledok.Text.Replace(".", ",");
                double vklad1 = 0;
                double kurz1 = 0;
                if (double.TryParse(vklad, out result))
                {
                    vklad1 = Convert.ToDouble(vklad);
                }
                if (double.TryParse(kurz, out result))
                {
                    kurz1 = Convert.ToDouble(kurz);
                }
                vysledok = lb_vysledok.Text.Split(' ');
                lb_moznavyhra.Text = (vklad1 * kurz1).ToString();

                string sql = $"INSERT INTO stavky (`id`, `mozna_vyhra`, `vysledok`) VALUES(\'{id}\', \'{lb_moznavyhra.Text}\', \'{lb_vysledok.Text}\')";
                MySqlCommand command = new MySqlCommand(sql, Database.connection);
                command.ExecuteNonQuery();
                change_balance(id, vklad1.ToString());
                appka.refresh_balance();
                
            }
            else
            {
                MessageBox.Show("Musíš niečo vložiť.");
                return;
            }

        }
        private string change_to_dot(string change)
        {
            string new_amount = "";
            change.Trim();
            foreach (char i in change)
            {
                if (i == ',')
                {
                    new_amount = new_amount + '.';
                }
                else new_amount = new_amount + i;
            }
            return new_amount;
        }
        private void change_balance(string id, string peniaze)
        {
            string balance = "";
            string sql = $"SELECT * FROM `user_balance` WHERE id={id}";
            MySqlCommand command = new MySqlCommand(sql, Database.connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return;
            }
            while (reader.Read())
            {

                balance = reader.GetString("balance");

            }
            reader.Close();
            balance = (float.Parse(balance) - float.Parse(peniaze)).ToString();
            string new_balance = change_to_dot(balance);
            string insert_sql = $"UPDATE user_balance SET balance = {new_balance} WHERE id = \'{id}\';";
            MySqlCommand insert_command = new MySqlCommand(insert_sql, Database.connection);
            insert_command.ExecuteNonQuery();
        }
    }
}