﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ForSport.Classes;
using System.Runtime.InteropServices;

namespace ForSport
{
    public partial class register_menu : Form
    {
        private login_menu menu;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public register_menu(login_menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text; // bere string z textboxu
            string password = tb_password.Text; // bere string z textboxu
            string mail = tb_email.Text; // bere string z textboxu

            Register register = new Register(username, password, mail);
            if (tb_username.Text != "" && tb_password.Text != "" && tb_email.Text != "") // pozrie ci sme zapisali meno,heslo a mail
            {
                register.register();
            }
            else
            {
                MessageBox.Show("Musis vyplnit vsetky policka");
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bt_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void toppanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
