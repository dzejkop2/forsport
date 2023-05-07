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
        private string id { get; }
        private string username { get; set; }
        private string password { get; set; }

        public Login(string meno, string heslo)
        {
            this.username = meno;
            this.password = heslo;
        }

        public bool login_verify()
        {
            string sql = $"SELECT username, password, id FROM login_info WHERE username = \'{this.username}\'";
            MySqlCommand command = new MySqlCommand(sql, Database.connection);
            MySqlDataReader reader = command.ExecuteReader();

            string id = "";
            string heslo = "";

            while (reader.Read())
            {
                id = reader.GetString("id");
                heslo = reader.GetString("password");
            }

            if (!reader.HasRows)
            {
                reader.Close();
                return false;
            }
            else if (heslo == password)
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
