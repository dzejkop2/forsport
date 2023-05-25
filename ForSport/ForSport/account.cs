using ForSport.Classes;
using Microsoft.Win32;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ForSport
{
    public partial class account : Form
    {
        private app app;
        private login_menu menu;
        string username, password, mail,id;
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Id { get => id; set => id = value; }

        public account(string username, string password, string mail,string id, app app, login_menu menu)
        {
            InitializeComponent();
            this.Username = username;
            this.Password = password;
            this.Mail = mail;
            this.Id = id;
            this.app = app;
            this.menu = menu;
            lb_name.Text = this.Username;
            lb_mail.Text = this.Mail;
            lb_password.Text = change_to_asterisk(this.Password);
            bt_accept.FlatAppearance.BorderSize = 0;
            
        }
        private void bt_change_name_Click(object sender, EventArgs e)
        {
            lb_change.Text = "Zmena Mena";
            lb_change1.Text = "Nové meno";
            lb_change2.Text = "Heslo";
            lb_change.Visible = true;
            lb_change1.Visible = true;
            lb_change2.Visible = true;
            tb_change1.Visible = true;
            tb_change2.Visible = true;
            bt_accept.Visible = true;
            lb_password.Text = change_to_asterisk(this.Password);
            cb_password.Visible = false;
            lb_change4.Visible = true;
        }

        private void bt_change_mail_Click(object sender, EventArgs e)
        {
            lb_change.Text = "Zmena E-mailu";
            lb_change1.Text = "Nový e-mail";
            lb_change2.Text = "Heslo";
            lb_change.Visible = true;
            lb_change1.Visible = true;
            lb_change2.Visible = true;
            tb_change1.Visible = true;
            tb_change2.Visible = true;
            bt_accept.Visible = true;
            lb_password.Text = change_to_asterisk(this.Password);
            cb_password.Visible = false;
            lb_change4.Visible = true;
        }

        private void bt_accept_Click(object sender, EventArgs e)
        {
            Change_info info = new Change_info();
            if (tb_change1.Text != "" && tb_change2.Text != "")
            {
                if (lb_change.Text == "Zmena Mena")
                {
                    if (tb_change1.Text != this.Username)
                    {
                        if (tb_change1.Text.Length <= 50)
                        {
                            if (tb_change2.Text == this.Password)
                            {
                                info.change_name(tb_change1.Text, this.Id);
                                MessageBox.Show("Zmena mena bola uspešna!");
                                menu.Show();
                                app.Close();
                            } 
                        }
                        else
                        {
                            MessageBox.Show("Meno musi byt mensie ako 50 znakov");
                        }
                    }
                    else MessageBox.Show("Toto meno už používaš");
                    
                }
                else if (lb_change.Text == "Zmena E-mailu")
                {
                    if (tb_change1.Text != this.Mail)
                    {
                        if (email_valid(tb_change1.Text))
                        {
                            if (tb_change2.Text == this.Password)
                            {
                                info.change_email(tb_change1.Text, this.Id);
                                MessageBox.Show("Zmena E-mailu bola uspešna!");
                                menu.Show();
                                app.Close();
                            }
                        }
                    }
                    else MessageBox.Show("Tento E-mail už používaš");
                }
                else if (lb_change.Text == "Zmena Hesla")
                {
                    if (tb_change1.Text != this.Password)
                    {
                        if (tb_change1.Text.Length <= 50)
                        {
                            if (tb_change2.Text == tb_change1.Text)
                            {
                                info.change_password(tb_change1.Text, this.Id);
                                MessageBox.Show("Zmena hesla bola uspešna!");
                                menu.Show();
                                app.Close();
                            }
                            else MessageBox.Show("Heslo sa ti nezhoduje!");
                        }
                        else
                        {
                            MessageBox.Show("Heslo musi byt mensie ako 50 znakov");
                        }
                    }
                    else MessageBox.Show("Toto heslo už používaš");
                }
            }
            else MessageBox.Show("Musiš vyplniť všetky polia");

        }

        private void cb_password_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_password.Checked == true)
            {
                lb_password.Text = this.Password;
            }
            else lb_password.Text = change_to_asterisk(this.Password);
            
        }

        private void bt_change_password_Click(object sender, EventArgs e)
        {
            lb_change.Text = "Zmena Hesla";
            lb_change1.Text = "Nové heslo";
            lb_change2.Text = "Zopakovať heslo";
            lb_change.Visible = true;
            lb_change1.Visible = true;
            lb_change2.Visible = true;
            tb_change1.Visible = true;
            tb_change2.Visible = true;
            bt_accept.Visible = true;
            lb_password.Text = change_to_asterisk(this.Password);
            cb_password.Visible = false;
            lb_change4.Visible = true;
        }
        private string change_to_asterisk(string to_asterisk)
        {
            string asterisk_string = "";

            int count = to_asterisk.Count();

            for (int i = 0; i < count; i++)
            {
                asterisk_string += "*";
            }

            return asterisk_string;
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