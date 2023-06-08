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
        app appka;
        List<Teams> tymy_list = new List<Teams>();
        List<Stavky> stavky_list = new List<Stavky>();
        List<Zapasy> zapasy_list = new List<Zapasy>();

        

        public zapasy(app appka)
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            bt_generuj.FlatAppearance.BorderSize = 0;
            this.appka = appka;
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
            //this.appka.refresh_balance();
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
            load_stavky();
            generate_zapasy();
            chekujem();
            //string sql = @"SELECT * FROM kurzy";
            //string[] vysledky = new string[8];
            //MySqlCommand command = new MySqlCommand(sql, Database.connection);
            //MySqlDataReader reader = command.ExecuteReader();
            //int k = 0;

            //if (!reader.HasRows)
            //{
            //    reader.Close();
            //    return;
            //}
            //while (reader.Read())
            //{
                
            //    vysledky[k] = reader.GetString("first_team");
            //    vysledky[k+1] = reader.GetString("second_team");
            //    k += 2;

            //}
            //reader.Close();

            ////nahodne vygeneruje goly pre kazdy tym
            //int[] goly = new int[8];
            //var random = new Random();
            //for (int l = 0; l < 8; l++)
            //{
            //    goly[l] = random.Next(10);
            //}


            
            //string sql1 = $"SELECT * FROM stavky";
            //MySqlCommand command1 = new MySqlCommand(sql1, Database.connection);
            //MySqlDataReader reader1 = command.ExecuteReader();
            //int i = 0;
            //string v = "";
            //string id = "";
            //string vyhra = "";
            //if (!reader1.HasRows)
            //{
            //    reader1.Close();
            //    return;
            //}
            //while (reader1.Read())
            //{

            //    v = reader1.GetString("vysledok");
            //    id = reader1.GetString("id");
            //    vyhra = reader1.GetString("mozna_vyhra");
            //    string[] x = v.Split(' ');
            //    string vysledok = "";
            //    if (x[1] == "vyhrá")
            //    {
            //        vysledok = "1";
            //    }
            //    else if (x[1] == "neprehrá")
            //    {
            //        vysledok = "10";
            //    }
            //    else if (x[1] == "remíza")
            //    {
            //        vysledok = "0";
            //    }
            //    else if (x[1] == "neprehrá2")
            //    {
            //        vysledok = "02";
            //    }
            //    else
            //    {
            //        vysledok = "2";
            //    }
            //    for( int p = 0; p < 8; p++)
            //    {
            //        if(vysledky[p] == x[0])
            //        {
            //            if ((p + 2) % 2 == 1)
            //            {
            //                if (vysledok == "02" && goly[p] >= goly[p - 1])
            //                {
            //                    MessageBox.Show("Vyhral");
            //                    change_balance(id, vyhra);

            //                }
            //                if (vysledok == "2" && goly[p] > goly[p - 1])
            //                {
            //                    MessageBox.Show("Vyhral si");
            //                    change_balance(id, vyhra);
            //                }
            //            }
            //            else
            //            {
            //                if (vysledok == "1" && goly[p] > goly[p + 1])
            //                {
            //                    MessageBox.Show("Vyhral si penaze");
            //                    change_balance(id, vyhra);
            //                }
            //                else if (vysledok == "10" && goly[p] >= goly[p + 1])
            //                {
            //                    MessageBox.Show("Vyhralsi");
            //                    change_balance(id, vyhra);
            //                }
            //                else if(vysledok == "0" && goly[p] == goly[p + 1])
            //                {
            //                    MessageBox.Show("vyhral si na remizu");
            //                    change_balance(id, vyhra);
            //                }
            //            }
            //        }
            //    }
            //    reader1.Close();
            //}

            

        }
        public void change_balance(string id, string peniaze)
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
            balance = (float.Parse(balance) + float.Parse(peniaze)).ToString();
            string new_balance = change_to_dot(balance);
            string insert_sql = $"UPDATE user_balance SET balance = {new_balance} WHERE id = \'{id}\';";
            MySqlCommand insert_command = new MySqlCommand(insert_sql, Database.connection);
            insert_command.ExecuteNonQuery();
        }
        private void load_stavky()
        {
            string sql = $"SELECT * FROM `stavky`";
            MySqlCommand command = new MySqlCommand(sql, Database.connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return;
            }
            while (reader.Read())
            {

                string robo;
                string id = reader.GetString("id");
                string vysledok;
                robo = reader.GetString("vysledok");
                string robo3 = reader.GetString("mozna_vyhra");
                string[] robo1 = new string[2];
                robo1 = robo.Split(' ');
                if (robo1[1] == "vyhrá")
                {
                    vysledok = "1";
                }
                else if (robo1[1] == "neprehrá")
                {
                    vysledok = "10";
                }
                else if (robo1[1] == "remíza")
                {
                    vysledok = "0";
                }
                else if (robo1[1] == "neprehrá2")
                {
                    vysledok = "02";
                }
                else
                {
                    vysledok = "2";
                }
                stavky_list.Add(new Stavky(id, robo1[0], vysledok, robo3));

            }
            reader.Close();
        }
        void generate_zapasy()
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
                vysledky[k + 1] = reader.GetString("second_team");
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
            for (int i = 0; i < 8; i+=2)
            {
                zapasy_list.Add(new Zapasy(vysledky[i], vysledky[i + 1], goly[i].ToString(), goly[i + 1].ToString()));
            }

        }

        void chekujem()
        {
            foreach (Stavky item in stavky_list)
            {
                foreach (Zapasy itemm in zapasy_list)
                {
                    if (item.Tym == itemm.Tym1 || item.Tym == itemm.Tym2)
                    {
                        if (item.Vysledok == "1" && Convert.ToInt32(itemm.Vysledok1) > Convert.ToInt32(itemm.Vysledok2))
                        {
                            change_balance(item.Id, item.Vyhra);
                            appka.refresh_balance();
                        }
                        else if (item.Vysledok == "10" && Convert.ToInt32(itemm.Vysledok1) >= Convert.ToInt32(itemm.Vysledok2))
                        {
                            change_balance(item.Id, item.Vyhra);
                            appka.refresh_balance();

                        }
                        else if (item.Vysledok == "0" && Convert.ToInt32(itemm.Vysledok1) == Convert.ToInt32(itemm.Vysledok2))
                        {
                            change_balance(item.Id, item.Vyhra);
                            appka.refresh_balance();

                        }
                        else if (item.Vysledok == "02" && Convert.ToInt32(itemm.Vysledok1) <= Convert.ToInt32(itemm.Vysledok2))
                        {
                            change_balance(item.Id, item.Vyhra);
                            appka.refresh_balance();

                        }
                        else if (item.Vysledok == "2" && Convert.ToInt32(itemm.Vysledok1) < Convert.ToInt32(itemm.Vysledok2))
                        {
                            change_balance(item.Id, item.Vyhra);
                            appka.refresh_balance();

                        }
                    }
                }
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
    }
    
    }

