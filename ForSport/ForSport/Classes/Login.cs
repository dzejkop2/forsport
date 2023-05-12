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

        private string id, username, password;

        // properties pre login a register

        public string Id { get => id; private set => id = value; }
        public string Username { get => username; private set => username = value; }
        public string Password { get => password; private set => password = value; }


        public Login(string meno, string heslo)
        {
            this.Username = meno;
            this.Password = heslo;
        }
        
        public bool login_verify() // metoda ktora kontroluje login informacie
        {
            string sql = $"SELECT username, password, id FROM user_info WHERE username = \'{this.Username}\'"; // sql prikaz
            MySqlCommand command = new MySqlCommand(sql, Database.connection); // vytvorenie objektu command
            MySqlDataReader reader = command.ExecuteReader(); // vytvorenie readeru s commandom

            string id = "";
            string heslo = "";

            if (!reader.HasRows) // pozrie ci reader nevratil prazdnu tabulku
            {
                reader.Close();
                return false;
            }
            while (reader.Read())
            {
                id = reader.GetString("id");
                heslo = reader.GetString("password");
            }
            if (heslo == Password) // pozrie ci sa heslo zhoduje s tym co sme zadali
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }
    }
}
