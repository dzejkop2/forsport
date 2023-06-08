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
    public partial class zapasy : Form
    {
        List<Teams> tymy_list = new List<Teams>();
        public zapasy()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            bt_generuj.FlatAppearance.BorderSize = 0;
        }

        private void bt_generuj_Click(object sender, EventArgs e)
        {

            string sql = $"TRUNCATE kurzy";
            MySqlCommand command = new MySqlCommand(sql, Database.connection);
            command.ExecuteNonQuery();
            sql = $"TRUNCATE stavky";
            command = new MySqlCommand(sql, Database.connection);
            command.ExecuteNonQuery();
            string[] tymy = new string[8];
            sql = $"SELECT * FROM tymy";
            command = new MySqlCommand(sql, Database.connection);
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            if (!reader.HasRows)
            {
                reader.Close();
                return;
            }
            while (reader.Read())
            {

                tymy[i] = reader.GetString("nazov");
                i++;
            }
            reader.Close();

            for (int j = 0; j < 8; j += 2)
            {
                insert_odd(tymy[j], tymy[j + 1]);
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

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM kurzy";
            string[] vysledky = new string[8];
            MySqlCommand command = new MySqlCommand(sql, Database.connection);
            MySqlDataReader reader = command.ExecuteReader();
            int k = 0;

            if (!reader.HasRows)
            {
                reader.Close();
                return;
            }
            while (reader.Read())
            {
                
                vysledky[k] = reader.GetString("first_team");
                vysledky[k+1] = reader.GetString("second_team");
                k += 2;

            }
            reader.Close();

            //nahodne vygeneruje goly pre kazdy tym
            int[] goly = new int[8];
            var random = new Random();
            for (int l = 0; l < 8; l++)
            {
                goly[l] = random.Next(10);
            }


            
            sql = $"SELECT * FROM stavky";
            command = new MySqlCommand(sql, Database.connection);
            reader = command.ExecuteReader();
            int i = 0;
            if (!reader.HasRows)
            {
                reader.Close();
                return;
            }
            while (reader.Read())
            {

                string v = reader.GetString("vysledok");
                string id = reader.GetString("id");
                string vyhra = reader.GetString("mozna_vyhra");
                string[] x = v.Split(' ');
                string vysledok;
                if (x[1] == "vyhrá")
                {
                    vysledok = "1";
                }
                else if (x[1] == "neprehrá")
                {
                    vysledok = "10";
                }
                else if (x[1] == "remíza")
                {
                    vysledok = "0";
                }
                else if (x[1] == "neprehrá2")
                {
                    vysledok = "02";
                }
                else
                {
                    vysledok = "2";
                }
                for( int p = 0; p < 8; p++)
                {
                    if(vysledky[p] == x[0])
                    {
                        if ((p + 2) % 2 == 1)
                        {
                            if (vysledok == "02" && goly[p] >= goly[p - 1])
                            {
                                MessageBox.Show("Vyhral");
                                change_balance(id, vyhra);

                            }
                            if (vysledok == "2" && goly[p] > goly[p - 1])
                            {
                                MessageBox.Show("Vyhral si");
                                change_balance(id, vyhra);
                            }
                        }
                        else
                        {
                            if (vysledok == "1" && goly[p] > goly[p + 1])
                            {
                                MessageBox.Show("Vyhral si penaze");
                                change_balance(id, vyhra);
                            }
                            else if (vysledok == "10" && goly[p] >= goly[p + 1])
                            {
                                MessageBox.Show("Vyhralsi");
                                change_balance(id, vyhra);
                            }
                            else if(vysledok == "0" && goly[p] == goly[p + 1])
                            {
                                MessageBox.Show("vyhral si na remizu");
                                change_balance(id, vyhra);
                            }
                        }
                    }
                }
                
            }

            reader.Close();

        }
        private void change_balance(string id, string peniaze)
        {
            string balance ="0";
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
            balance = (Convert.ToDouble(balance) + Convert.ToDouble(peniaze)).ToString();
            sql = $"DELETE FROM `user_balance` WHERE id={id}";
            command = new MySqlCommand(sql, Database.connection);
            command.ExecuteNonQuery();
            sql = $"INSERT INTO `user_balance` (`id`, `balance`) VALUES (\'{id}\', \'{balance}\');";
            command = new MySqlCommand(sql, Database.connection);
            command.ExecuteNonQuery();
        }
        }
    }

