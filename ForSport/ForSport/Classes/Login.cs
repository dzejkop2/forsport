using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForSport
{
    internal class Login
    {

        private string id, username, password, mail;
        private float balance;

        // properties pre login a register

        public string Id { get => id; private set => id = value; }
        public string Username { get => username; private set => username = value; }
        public string Password { get => password; private set => password = value; }
        public string Mail { get => mail; private set => mail = value; }
        public float Balance { get => balance; private set => balance = value; }

        public Login(string meno, string heslo)
        {
            this.Username = meno;
            this.Password = heslo;
        }
        
        public bool login_verify() // metoda ktora kontroluje login informacie
        {
            bool check;
            string heslo = "";

            string sql = $"SELECT username,password,id,mail FROM user_info WHERE username = \'{this.Username}\'"; // sql prikaz
            MySqlCommand command = new MySqlCommand(sql, Database.connection); // vytvorenie objektu command

            MySqlDataReader reader = command.ExecuteReader(); // vytvorenie readeru s commandom
            
            if (!reader.HasRows) // pozrie ci reader nevratil prazdnu tabulku
            {
                reader.Close();
                return false;
            }
            while (reader.Read())
            {
                this.Id = reader.GetString("id");
                this.Mail = reader.GetString("mail");
                heslo = reader.GetString("password");
            }
            if (heslo == Password) // pozrie ci sa heslo zhoduje s tym co sme zadali
            {
                reader.Close();
                check = true;
            }
            else
            {
                reader.Close();
                check = false;
            }
            string sql_balance = $"SELECT balance FROM user_balance WHERE id = \'{this.Id}\'";
            MySqlCommand command_balance = new MySqlCommand(sql_balance, Database.connection);
            MySqlDataReader reader_balance = command_balance.ExecuteReader();

            if (!reader_balance.HasRows)
            {
                reader_balance.Close();
                MessageBox.Show("NEMAS V DATABAZE DOBRE LOOOOOOOL");
                return false;
            }
            while (reader_balance.Read())
            {
                this.Balance = reader_balance.GetFloat("balance");
            }
            reader_balance.Close();

            if (check == false)
            {
                return false;
            }
            else return true;
        }
    }
}
