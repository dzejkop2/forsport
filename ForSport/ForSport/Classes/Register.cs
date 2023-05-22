using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ForSport.Classes
{
    internal class Register
    {
        private string id, username, password, mail;
        private float balance;
        // properties pre login a register

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Mail { get => mail; set => mail = value; }
        public float Balance { get => balance; set => balance = value; }


        public Register(string meno, string heslo, string mail)
        {
            this.Username = meno;
            this.Password = heslo;
            this.Mail = mail;
        }

        private bool check(string parameter, string property) // metoda pre checkovanie 
        {
            string check_sql = $"SELECT * FROM user_info WHERE {parameter} = '{property}'"; // sql kde sa vyhlada v tabulke ci sa uz take data v tabulke nenachadzaju
            MySqlCommand check = new MySqlCommand(check_sql, Database.connection); // vytvorenie objektu check
            MySqlDataReader reader = check.ExecuteReader(); // vytvorenie readeru s commandom check

            if (reader.HasRows) // pozrie ci to nieco reader v tabulke nasiel
            {
                reader.Close();
                return false;
            }
            else // ak nenasiel
            {
                reader.Close();
                return true;
            }
        }
        private static bool email_valid(string email)
        {
            var valid = true;

            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }

            return valid;
        }

        public bool register() // metoda na registraciu pouzivatela
        {
            IdGenerator id = new IdGenerator();
            this.Id = id.new_id();

            if (check("username", this.username) == false) // pozrie ci uz rovnake meno existuje
            {
                MessageBox.Show("Toto meno uz existuje");
                return false;
            }
            if (check("mail", this.mail) == false) // pozrie ci bol mail pouzity
            {
                MessageBox.Show("Na tento mail uz existuje konto");
                return false;
            }
            if(email_valid(this.mail) == false)
            {
                MessageBox.Show("Tento mail nie je správny");
                return false;
            }
            while (true)
            {
                if (check("id", this.Id) == false) // pozrie ci ID je unikatne
                {
                    this.Id = id.new_id();
                }
                else break;
            }

            MessageBox.Show("Uspesne si sa registroval"); //debug messagebox

            string insert_sql = $"INSERT INTO user_info (`id`, `username`, `password`, `mail`) VALUES(\'{this.Id}\', \'{this.Username}\', \'{this.Password}\', \'{this.Mail}\')"; // sql na vpisanie dat do DB
            MySqlCommand insert_command = new MySqlCommand(insert_sql, Database.connection); // vytvorenie komandu 
            insert_command.ExecuteNonQuery(); // zapis do DB

            this.Balance = 0;

            string insert_balance_sql = $"INSERT INTO user_balance (`id`, `balance`) VALUES(\'{this.Id}\',\'0.00\')"; // sql na vpisanie dat do DB
            MySqlCommand insert_balance_command = new MySqlCommand(insert_balance_sql, Database.connection); // vytvorenie komandu 
            insert_balance_command.ExecuteNonQuery(); // zapis do DB
            return true;
        }
    }
}