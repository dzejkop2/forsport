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
    public partial class pavuk : Form
    {
        List<Pavuk> pavuk_list = new List<Pavuk>();
        List<Pavuk> pavuk_postup_list = new List<Pavuk>();
        public pavuk()
        {
            InitializeComponent();
            string sql = $"SELECT COUNT(*) FROM kurzy;";
            MySqlCommand command = new MySqlCommand(sql, Database.connection);
            int pocet_kurzov = Convert.ToInt32(command.ExecuteScalar());
            if (pocet_kurzov > 0)
            {
                get_team();
                bt_vymaz.Visible = true;
                bt_vytvor.Visible = false;
            }
            else
            {
                bt_vymaz.Visible = false;
                bt_vytvor.Visible = true;
            }

        }

        private void bt_vytvor_Click(object sender, EventArgs e)
        {
            //vytvori styri kurzi a z nich dosadi do pavuka + sa moze stavkovat
            if (check_teams())
            {
                get_team();
                /*string sql = $"INSERT INTO kurzy (`nazov`, `body`) VALUES(\'{textBox1.Text}\', \'0\')";
                MySqlCommand command = new MySqlCommand(sql, Database.connection);
                command.ExecuteNonQuery();*/
                insert_odd(lb_team1.Text, lb_team2.Text);
                insert_odd(lb_team3.Text, lb_team4.Text);
                insert_odd(lb_team5.Text, lb_team6.Text);
                insert_odd(lb_team7.Text, lb_team8.Text);
                bt_vytvor.Visible = false;
                bt_vymaz.Visible = true;
            }

        }
        private bool check_teams()
        {
            string sql = $"SELECT COUNT(*) FROM tymy;";
            MySqlCommand command = new MySqlCommand(sql, Database.connection);
            int pocet_tymov = Convert.ToInt32(command.ExecuteScalar());
            if (pocet_tymov != 8)
            {
                MessageBox.Show("Potrebuješ 8 týmov na vytvorenie pavúka. Práve existuje " + pocet_tymov);
                return false;
            }
            else
            {
                MessageBox.Show("Máš presne 8 týmov");
                return true;
            }
        }
        
        private void insert_odd(string prvy_team, string druhy_team)
        {
            var random = new Random();
            string[] kurzy = new string[5];
            for (int i = 0; i < 5; i++)
            {
                int number = random.Next(1, 4);
                int decimal_number = random.Next(1, 100);
                kurzy[i] = number.ToString() + "." + decimal_number.ToString();
            }
            string sql = $"INSERT INTO kurzy (`first_team`, `second_team`, `date`, `kurz1`, `kurz10`, `kurz0`, `kurz02`, `kurz2`) VALUES(\'{prvy_team}\', \'{druhy_team}\', \'0\',\'{kurzy[0]}\',\'{kurzy[1]}\',\'{kurzy[2]}\',\'{kurzy[3]}\',\'{kurzy[4]}\')";
            MySqlCommand command = new MySqlCommand(sql, Database.connection);
            command.ExecuteNonQuery();


        }
        private void get_team()
        {
            string tymy;
            int j = 0;
            string sql = $"SELECT * FROM tymy";
            MySqlCommand command = new MySqlCommand(sql, Database.connection);
            MySqlDataReader reader = command.ExecuteReader();

            if (!reader.HasRows)
            {
                reader.Close();
                return;
            }
            while (reader.Read())
            {
                tymy = reader.GetString("nazov");
                pavuk_list.Add(new Pavuk(tymy));
                j++;
            }
            reader.Close();
            lb_team1.Text = pavuk_list[0].Meno;
            lb_team2.Text = pavuk_list[1].Meno;
            lb_team3.Text = pavuk_list[2].Meno;
            lb_team4.Text = pavuk_list[3].Meno;
            lb_team5.Text = pavuk_list[4].Meno;
            lb_team6.Text = pavuk_list[5].Meno;
            lb_team7.Text = pavuk_list[6].Meno;
            lb_team8.Text = pavuk_list[7].Meno;
            sql = $"SELECT * FROM vysledky";
            MySqlCommand command1 = new MySqlCommand(sql, Database.connection);
            MySqlDataReader reader1 = command1.ExecuteReader();
            

            if (!reader1.HasRows)
            {
                reader1.Close();
                return;
            }
            while (reader1.Read())
            {
                int vysledok1 = Convert.ToInt16(reader1.GetString("prve_skore"));
                int vysledok2 = Convert.ToInt16(reader1.GetString("druhe_skore"));
                if (vysledok1 >= vysledok2)
                {
                    tymy = reader1.GetString("prvy_team");
                }
                else
                {
                    tymy = reader1.GetString("druhy_team");
                }
                
                pavuk_postup_list.Add(new Pavuk(tymy));
                j++;
            }reader1.Close();
            if (pavuk_postup_list.Count > 0)
            {
                lb_team2.Text = pavuk_list[1].Meno + ": " + pavuk_list[1].Vysledok;
                lb_team3.Text = pavuk_list[2].Meno + ": " + pavuk_list[2].Vysledok;
                lb_team4.Text = pavuk_list[3].Meno + ": " + pavuk_list[3].Vysledok;
                lb_team5.Text = pavuk_list[4].Meno + ": " + pavuk_list[4].Vysledok;
                lb_team6.Text = pavuk_list[5].Meno + ": " + pavuk_list[5].Vysledok;
                lb_team7.Text = pavuk_list[6].Meno + ": " + pavuk_list[6].Vysledok;
                lb_team8.Text = pavuk_list[7].Meno + ": " + pavuk_list[7].Vysledok;
                lb_team1.Text = pavuk_list[0].Meno + ": " + pavuk_list[0].Vysledok;
                lb_postup1.Visible = true;
                lb_postup2.Visible = true;
                lb_postup3.Visible = true;
                lb_postup4.Visible = true;
                lb_postup1.Text = pavuk_postup_list[0].Meno;
                lb_postup2.Text = pavuk_postup_list[1].Meno;
                lb_postup3.Text = pavuk_postup_list[2].Meno;
                lb_postup4.Text = pavuk_postup_list[3].Meno;
            }

        }

        private void bt_vymaz_Click(object sender, EventArgs e)
        {
            lb_team1.Text = "team1";
            lb_team2.Text = "team2";
            lb_team3.Text = "team3";
            lb_team4.Text = "team4";
            lb_team5.Text = "team5";
            lb_team6.Text = "team6";
            lb_team7.Text = "team7";
            lb_team8.Text = "team8";
            lb_postup1.Visible = false;
            lb_postup2.Visible = false;
            lb_postup3.Visible = false;
            lb_postup4.Visible = false;

            string sql = $"TRUNCATE kurzy";
            string sql1 = $"TRUNCATE vysledky";
            MySqlCommand command = new MySqlCommand(sql, Database.connection);
            command.ExecuteNonQuery();
            MySqlCommand command1 = new MySqlCommand(sql1, Database.connection);
            command1.ExecuteNonQuery();
            sql = $"TRUNCATE stavky";
            command = new MySqlCommand(sql, Database.connection);
            command.ExecuteNonQuery();
            bt_vymaz.Visible = false;
            bt_vytvor.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] goly = new int[8];
            var random = new Random();
            for (int i = 0; i < 8; i++)
            {
                goly[i] = random.Next(10);
                pavuk_list[i].Vysledok = goly[i].ToString();
            }
            for (int i = 0; i < 8; i += 2)
            if (goly[i] >= goly[i+1])
            {
                pavuk_postup_list.Add(new Pavuk(pavuk_list[i].Meno));
            }
            else if(goly[i] < goly[i+1])
            {
                pavuk_postup_list.Add(new Pavuk(pavuk_list[i+1].Meno));
            }
            for(int i = 0; i < 8;i += 2)
            {
                string sql = $"INSERT INTO vysledky (`prvy_team`, `druhy_team`, `prve_skore`, `druhe_skore`) VALUES (\'{pavuk_list[i].Meno}\', \'{pavuk_list[i+1].Meno}\', \'{pavuk_list[i].Vysledok}\',\'{pavuk_list[i+1].Vysledok}\')";
                MySqlCommand command = new MySqlCommand(sql, Database.connection);
                command.ExecuteNonQuery();
            }
            lb_team2.Text = pavuk_list[1].Meno + ": " + pavuk_list[1].Vysledok;
            lb_team3.Text = pavuk_list[2].Meno + ": " + pavuk_list[2].Vysledok;
            lb_team4.Text = pavuk_list[3].Meno + ": " + pavuk_list[3].Vysledok;
            lb_team5.Text = pavuk_list[4].Meno + ": " + pavuk_list[4].Vysledok;
            lb_team6.Text = pavuk_list[5].Meno + ": " + pavuk_list[5].Vysledok;
            lb_team7.Text = pavuk_list[6].Meno + ": " + pavuk_list[6].Vysledok;
            lb_team8.Text = pavuk_list[7].Meno + ": " + pavuk_list[7].Vysledok;
            lb_team1.Text = pavuk_list[0].Meno + ": " + pavuk_list[0].Vysledok;
            lb_postup1.Visible = true;
            lb_postup2.Visible = true;
            lb_postup3.Visible = true;
            lb_postup4.Visible = true;
            lb_postup1.Text = pavuk_postup_list[0].Meno;
            lb_postup2.Text = pavuk_postup_list[1].Meno;
            lb_postup3.Text = pavuk_postup_list[2].Meno;
            lb_postup4.Text = pavuk_postup_list[3].Meno;
        }
    }   
}
