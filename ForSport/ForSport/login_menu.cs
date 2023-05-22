using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ForSport.Classes;
using MySql.Data.MySqlClient;


namespace ForSport
{
    public partial class login_menu : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public login_menu()
        {
            InitializeComponent();
            bt_exit.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderSize = 0;
            bt_minimize.FlatAppearance.BorderSize = 0;
            tb_password.PasswordChar = '*';
        }

            /* debug id generatoru
            IdGenerator id = new IdGenerator();
            id.new_id();
            MessageBox.Show(id.id);
            */

        private void button1_Click(object sender, EventArgs e) // button pre pripojenie
        {
            string username = tb_username.Text; // bere string z textboxu
            string password = tb_password.Text; // bere string z textboxu
            Login login = new Login(username, password);

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                lb_caps.Text = "Máš zapnutý Caps Lock";
            }
            else
            {
                lb_caps.Text = "";
            }
            if (tb_username.Text != "" && tb_password.Text != "") // pozrie ci sme zapisali meno aj heslo
            {
                bool valid_login = login.login_verify(); // metoda ktora vrati ci bolo uspesne prihlasenie (heslo sa zhodovalo ku menu)
                if (valid_login == true)
                {
                    MessageBox.Show("Uspesne si sa prihlasil");
                    new app(login.Username,login.Password,login.Id,login.Mail,login.Balance).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Prihlasenie sa nepodarilo alebo nemáš založený účet");
                }
            }
            else
            {
                MessageBox.Show("Musis zadat meno aj heslo!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            register_menu Register = new register_menu(this);
            this.Hide();
            Register.Show();
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
