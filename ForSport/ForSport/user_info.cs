using ForSport.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ForSport
{
    public partial class user_info : Form
    {
        private string id, username, password, mail;
        private float balance;
        public string Id { get => id; private set => id = value; }
        public string Username { get => username; private set => username = value; }
        public string Password { get => password; private set => password = value; }
        public string Mail { get => mail; private set => mail = value; }
        public float Balance { get => balance; private set => balance = value; }
        public user_info(string id)
        {
            this.Id = id;
            InitializeComponent();
            refresh_data();
            bt_commit.FlatAppearance.BorderSize = 0;
        }

        private void lb_balance_DoubleClick(object sender, EventArgs e)
        {
            lb_zmena.Text = "Zmena balancu";
            lb_zmena2.Text = "Nový balance";
            lb_zmena.Visible = true;
            bt_commit.Visible = true;
            lb_zmena2.Visible = true;
            tb_zmena.Visible = false;
            tb_zmena_balance.Visible = true;
        }
        private void lb_name_DoubleClick(object sender, EventArgs e)
        {
            lb_zmena.Text = "Zmena mena";
            lb_zmena2.Text = "Nové meno";
            lb_zmena.Visible = true;
            bt_commit.Visible = true;
            lb_zmena2.Visible = true;
            tb_zmena.Visible = true;
            tb_zmena_balance.Visible = false;
        }
        private void lb_mail_DoubleClick(object sender, EventArgs e)
        {
            lb_zmena.Text = "Zmena e-mailu";
            lb_zmena2.Text = "Nový mail";
            lb_zmena.Visible = true;
            bt_commit.Visible = true;
            lb_zmena2.Visible = true;
            tb_zmena.Visible = true;
            tb_zmena_balance.Visible = false;
        }

        private void bt_commit_Click(object sender, EventArgs e)
        {
            Change_info info = new Change_info();
            if (tb_zmena.Visible == true)
            {
                if (tb_zmena.Text != "")
                { 
                    if (lb_zmena2.Text == "Nové heslo")
                    {
                        if (tb_zmena.Text.Length <= 50)
                        {
                            info.change_password(tb_zmena.Text,this.Id);
                            refresh_data();
                        }
                        else MessageBox.Show("Heslo musí mať menej ako 50 znakov");
                    }
                    else if (lb_zmena2.Text == "Nový mail")
                    {
                        if (email_valid(tb_zmena.Text) == true)
                        {
                            info.change_email(tb_zmena.Text, this.Id);
                        }
                        else MessageBox.Show("Tento e-mail nie je správny");
                    }
                    else if (lb_zmena2.Text == "Nové meno")
                    {
                        if (tb_zmena.Text.Length <= 50)
                        {
                            info.change_name(tb_zmena.Text, this.Id);
                            refresh_data();
                        }
                        else MessageBox.Show("Meno musí mať menej ako 50 znakov");
                    }
                }
                else MessageBox.Show("Musíš vyplniť na čo chceš túto hodnotu zmeniť");
            }
            
            if (tb_zmena_balance.Visible == true)
            {
                if (tb_zmena_balance.Text != "")
                { 
                    if (lb_zmena2.Text == "Nový balance")
                    { 
                        info.change_balance(float.Parse(tb_zmena_balance.Text), this.Id);
                    }
                }
                else MessageBox.Show("Musíš vyplniť na čo chceš túto hodnotu zmeniť");
            }
            tb_zmena.Text = "";
            tb_zmena_balance.Text = "";
            refresh_data();
        }

        private void lb_password_DoubleClick(object sender, EventArgs e)
        {
            lb_zmena.Text = "Zmena password";
            lb_zmena2.Text = "Nové heslo";
            lb_zmena.Visible = true;
            bt_commit.Visible = true;
            lb_zmena2.Visible = true;
            tb_zmena.Visible = true;
            tb_zmena_balance.Visible = false;
        }

        private void tb_zmena_balance_Validating(object sender, CancelEventArgs e)
        {
            float value;
            if (!float.TryParse(tb_zmena_balance.Text, out value)) { tb_zmena_balance.Text = ""; }
        }

        private void refresh_data()
        {
            fetch_data();
            lb_name.Text = this.Username;
            lb_password.Text = this.Password;
            lb_mail.Text = this.Mail;
            lb_balance.Text = this.Balance.ToString() + "€";
        }

        private void fetch_data()
        {
            string sql = $"SELECT username,password,id,mail FROM user_info WHERE id = \'{this.Id}\'"; // sql prikaz
            MySqlCommand command = new MySqlCommand(sql, Database.connection); // vytvorenie objektu command

            MySqlDataReader reader = command.ExecuteReader(); // vytvorenie readeru s commandom

            if (!reader.HasRows) // pozrie ci reader nevratil prazdnu tabulku
            {
                reader.Close();
                return;
            }
            while (reader.Read())
            {
                this.Username = reader.GetString("username");
                this.Password = reader.GetString("password");
                this.Mail = reader.GetString("mail");
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

    }
}
