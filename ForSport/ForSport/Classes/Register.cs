using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ForSport.Classes
{
    internal class Register
    {
        private string id, username, password, mail;

        // properties pre login a register

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Mail { get => mail; set => mail = value; }


        public Register(string meno, string heslo, string mail)
        {
            this.Username = meno;
            this.Password = heslo;
            this.Mail = mail;
        }

        private bool check_username()
        {
            string check_name_sql = $"SELECT * FROM user_info WHERE username = '{this.Username}'";
            MySqlCommand check_username = new MySqlCommand(check_name_sql, Database.connection); // vytvorenie objektu command
            MySqlDataReader reader = check_username.ExecuteReader(); // vytvorenie readeru s commandom

            string meno = "";

            while (reader.Read())
            {
                meno = reader.GetString("username");
            }
            if (reader.HasRows)
            {
                reader.Close();
                return false;
            }
            else
            {
                reader.Close();
                return true;
            }
        }

        private bool check_mail()
        {
            string check_mail_sql = $"SELECT * FROM user_info WHERE mail = '{this.Mail}'";
            MySqlCommand check_mail = new MySqlCommand(check_mail_sql, Database.connection); // vytvorenie objektu command
            MySqlDataReader reader = check_mail.ExecuteReader(); // vytvorenie readeru s commandom

            string email = "";

            while (reader.Read())
            {
                email = reader.GetString("mail");
            }
            if (reader.HasRows)
            {
                reader.Close();
                return false;
            }
            else
            {
                reader.Close();
                return true;
            }
        }

        private bool check_id()
        {
            string check_id_sql = $"SELECT id FROM user_info WHERE id = '{this.Id}'";
            MySqlCommand id_check = new MySqlCommand(check_id_sql, Database.connection); // vytvorenie objektu command
            MySqlDataReader reader = id_check.ExecuteReader(); // vytvorenie readeru s commandom

            string user_id = "";

            while (reader.Read())
            {
                user_id = reader.GetString("id");
            }
            if (reader.HasRows)
            {
                reader.Close();
                return false;
            }
            else
            {
                reader.Close();
                return true;
            }
        }

        public void register() // metoda na registraciu pouzivatela
        {
            IdGenerator id = new IdGenerator();
            bool unique_name = check_username();
            bool unique_mail = check_mail();
            this.Id = id.new_id();

            if (unique_name == false)
            {
                MessageBox.Show("Toto meno uz existuje");
                return;
            }
            if (unique_mail == false)
            {
                MessageBox.Show("Na tento mail uz existuje konto");
                return;
            }
            while (true)
            {
                bool unique_id = check_id();

                if (unique_id == false)
                {
                    this.Id = id.new_id();
                }
                else break;
            }

            MessageBox.Show("Uspesne si sa registroval"); //debug messagebox
            
            string insert_sql = $"INSERT INTO user_info (`id`, `username`, `password`, `mail`) VALUES(\'{this.Id}\', \'{this.Username}\', \'{this.Password}\', \'{this.Mail}\')";
            MySqlCommand insert_command = new MySqlCommand(insert_sql, Database.connection);
            insert_command.ExecuteNonQuery();
        }
    }
}
