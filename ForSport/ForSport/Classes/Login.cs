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
        // properties pre login a register
        private string id { get; }
        private string username { get; set; }
        private string password { get; set; }

        public Login(string meno, string heslo)
        {
            this.username = meno;
            this.password = heslo;
        }

        public bool login_verify() // metoda ktora kontroluje login informacie
        {
            string sql = $"SELECT username, password, id FROM login_info WHERE username = \'{this.username}\'"; // sql prikaz
            MySqlCommand command = new MySqlCommand(sql, Database.connection); // vytvorenie objektu command
            MySqlDataReader reader = command.ExecuteReader(); // vytvorenie readeru s commandom

            string id = "";
            string heslo = "";

            while (reader.Read())
            {
                id = reader.GetString("id");
                heslo = reader.GetString("password");
            }
            if (!reader.HasRows) // pozrie ci reader nevratil prazdnu tabulku
            {
                reader.Close();
                return false;
            }
            else if (heslo == password) // pozrie ci sa heslo zhoduje s tym co sme zadali
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
