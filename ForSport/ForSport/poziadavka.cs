using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForSport
{
    public partial class poziadavka : Form
    {

        private string id, username;
        private float balance,wanted_balance;
        private admin_poziadavky poziadavky;
        private string poziadavka_id, poziadavka_balance;
        public string Id { get => id; private set => id = value; }
        public string Username { get => username; private set => username = value; }
        public float Balance { get => balance; private set => balance = value; }
        public float Wanted_balance { get => wanted_balance; set => wanted_balance = value; }

        public poziadavka(string id, string wanted_balance, admin_poziadavky poziadavky)
        {
            InitializeComponent();
            this.poziadavka_id = id;
            this.poziadavka_balance = wanted_balance;
            this.poziadavky = poziadavky;
            fetch_data();
            lb_user.Text = $"{this.Username} žiada o {this.Wanted_balance}€ \n Práve má {this.Balance}€";
        }

        private void bt_accept_Click(object sender, EventArgs e)
        {
            float new_balance = this.Balance + this.Wanted_balance;
            string novy_balance = change_to_dot(new_balance.ToString());
            accept(novy_balance);
            this.Close();
            poziadavky.refresh_datagrid();
        }

        private void bt_deny_Click(object sender, EventArgs e)
        {
            deny();
            this.Close();
            poziadavky.refresh_datagrid();
        }

        private void fetch_data()
        {
            string sql = $"SELECT username,password,id,mail FROM user_info WHERE id = \'{poziadavka_id}\'";
            MySqlCommand command = new MySqlCommand(sql, Database.connection);

            MySqlDataReader reader = command.ExecuteReader();

            if (!reader.HasRows)
            {
                reader.Close();
                return;
            }
            while (reader.Read())
            {
                this.Username = reader.GetString("username");
                this.Id = reader.GetString("id");
            }
            reader.Close();

            string sql_balance = $"SELECT balance FROM user_balance WHERE id = \'{this.Id}\'";
            MySqlCommand command_balance = new MySqlCommand(sql_balance, Database.connection);
            MySqlDataReader reader_balance = command_balance.ExecuteReader();

            if (!reader_balance.HasRows)
            {
                reader_balance.Close();
                return;
            }
            while (reader_balance.Read())
            {
                this.Balance = reader_balance.GetFloat("balance");
            }
            reader_balance.Close();


            string pozadovany_balance = change_to_dot(poziadavka_balance);
            string sql_poziadavka = $"SELECT amount FROM poziadavky WHERE id = \'{this.Id}\' AND amount = {pozadovany_balance}";
            MySqlCommand command_poziadavka = new MySqlCommand(sql_poziadavka, Database.connection);
            MySqlDataReader reader_poziadavka = command_poziadavka.ExecuteReader();

            if (!reader_poziadavka.HasRows)
            {
                reader_poziadavka.Close();
                return;
            }
            while (reader_poziadavka.Read())
            {
                this.Wanted_balance = reader_poziadavka.GetFloat("amount");
            }
            reader_poziadavka.Close();
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
        private void accept(string new_balance)
        {
            string pozadovany_balance = change_to_dot(this.Wanted_balance.ToString());
            string insert_sql = $" UPDATE user_balance SET balance = {new_balance} WHERE id = \'{this.Id}\';"; 
            MySqlCommand insert_command = new MySqlCommand(insert_sql, Database.connection); 
            insert_command.ExecuteNonQuery();
            string delete_sql = $" DELETE FROM poziadavky WHERE id = \'{this.Id}\' AND amount = {pozadovany_balance} ;"; 
            MySqlCommand delete_command = new MySqlCommand(delete_sql, Database.connection);
            delete_command.ExecuteNonQuery();
        }
        private void deny()
        {
            string pozadovany_balance = change_to_dot(this.Wanted_balance.ToString());
            string delete_sql = $" DELETE FROM poziadavky WHERE id = \'{this.Id}\' AND amount = {pozadovany_balance} ;";
            MySqlCommand delete_command = new MySqlCommand(delete_sql, Database.connection);
            delete_command.ExecuteNonQuery();
        }
    }
}
