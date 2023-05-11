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
using static Org.BouncyCastle.Crypto.Digests.SkeinEngine;

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


        private string make_capital(string capital)
        {
            return char.ToUpper(capital[0]) + capital.Substring(1);
        }

        private bool check(string parameter)
        {
            
            string check_sql = $"SELECT {parameter} FROM user_info WHERE id = '{make_capital(parameter)}'";
            MySqlCommand command = new MySqlCommand(check_sql, Database.connection); // vytvorenie objektu command
            MySqlDataReader reader = command.ExecuteReader(); // vytvorenie readeru s commandom

            string check = "";

            while (reader.Read())
            {
                check = reader.GetString($"{parameter}");
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
            bool unique_name = check("username");
            bool unique_mail = check("mail");
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
                bool unique_id = check("id");

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
