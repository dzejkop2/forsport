﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;


namespace ForSport
{
    public partial class login_menu : Form
    {
        Database db = new Database(); // vytvorenie objektu cez ktory sa pripaja do DB

        public login_menu()
        {
            InitializeComponent();
            db.connect(); // samotne pripojenie, vykona sa na zaciatku programu
        }

        private void button1_Click(object sender, EventArgs e) // button pre pripojenie
        {
            string username = tb_username.Text; // bere string z textboxu
            string password = tb_password.Text; // bere string z textboxu
            Login login = new Login(username, password);
            if (tb_username.Text != "" && tb_password.Text != "") // pozrie ci sme zapisali meno aj heslo
            {
                bool valid_login = login.login_verify(); // metoda ktora vrati ci bolo uspesne prihlasenie (heslo sa zhodovalo ku menu)
                if (valid_login == true)
                {
                    MessageBox.Show("Uspesne si sa prihlasil");
                }
                else
                {
                    MessageBox.Show("Prihlasenie sa nepodarilo");
                }
            }
            else
            {
                MessageBox.Show("Musis zadat meno aj heslo!");
            }
        }

    }
}
