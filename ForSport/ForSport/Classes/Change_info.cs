using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForSport.Classes
{
    internal class Change_info
    {
        public void change_name(string new_name, string id)
        {
            bool vysledok = check("username", new_name);
            if (vysledok == true)
            {
                string insert_sql = $" UPDATE user_info SET username = \'{new_name}\' WHERE id = \'{id}\';"; // sql na vpisanie dat do DB
                MySqlCommand insert_command = new MySqlCommand(insert_sql, Database.connection); // vytvorenie komandu 
                insert_command.ExecuteNonQuery();
            }
            else MessageBox.Show("Toto meno už používa niekto iný, skús zadať iné");
        }
        public void change_email(string new_email, string id)
        {
            bool vysledok = check("mail", new_email);
            if (vysledok == true)
            {
                string insert_sql = $" UPDATE user_info SET mail = \'{new_email}\' WHERE id = \'{id}\';"; // sql na vpisanie dat do DB
                MySqlCommand insert_command = new MySqlCommand(insert_sql, Database.connection); // vytvorenie komandu 
                insert_command.ExecuteNonQuery();
            }
            else MessageBox.Show("Tento E-mail už používa niekto iný, skús zadať iné");
        }
        public void change_password(string new_password, string id)
        {
            string insert_sql = $" UPDATE user_info SET password = \'{new_password}\' WHERE id = \'{id}\';"; // sql na vpisanie dat do DB
            MySqlCommand insert_command = new MySqlCommand(insert_sql, Database.connection); // vytvorenie komandu 
            insert_command.ExecuteNonQuery();
        }
        public void change_balance(float new_balance, string id)
        {
            string insert_sql = $" UPDATE user_balance SET balance = {new_balance} WHERE id = \'{id}\';"; // sql na vpisanie dat do DB
            MySqlCommand insert_command = new MySqlCommand(insert_sql, Database.connection); // vytvorenie komandu 
            insert_command.ExecuteNonQuery();
        }
        private bool check(string parameter, string to_check)
        {
            string sql = $"SELECT * FROM user_info WHERE {parameter} = \'{to_check}\'";
            MySqlCommand command = new MySqlCommand(sql, Database.connection); 

            MySqlDataReader reader = command.ExecuteReader();

            if (!reader.HasRows)
            {
                reader.Close();
                return true;
            }
            return false;
        }
        
    }
}
