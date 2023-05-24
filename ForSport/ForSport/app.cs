using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace ForSport
{
    public partial class app : Form
    {
        private login_menu menu;
        string id, username, password, mail;
        float balance;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Mail { get => mail; set => mail = value; }
        public float Balance { get => balance; set => balance = value; }

        private void refresh_balance()
        {
            lb_balance.Text = $"Balance: {this.Balance}" + "€";
        }

        public app(string username, string password, string id, string mail, float balance, login_menu menu)
        {
            
            InitializeComponent();
            bt_kurzy.FlatAppearance.BorderSize = 0;
            bt_forum.FlatAppearance.BorderSize = 0;
            bt_live.FlatAppearance.BorderSize = 0;
            bt_vysledky.FlatAppearance.BorderSize = 0;
            bt_admin.FlatAppearance.BorderSize = 0;
            btn_exit.FlatAppearance.BorderSize = 0;
            bt_minimize.FlatAppearance.BorderSize = 0;  
            this.Username = username;
            this.Password = password;
            this.Id = id;
            this.Mail = mail;
            this.Balance = balance;
            this.menu = menu;
            lb_account.Text = $"Prihlaseny ako: {this.Username}";
            refresh_balance();

            if (id != "1111111111")
            {
                bt_admin.Hide();
            }
        }

        private void app_load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"..\Resources\RobotoSerif.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
            }
        }

        public void loadform(object Form)
        {
            Form f = Form as Form;
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void bt_kurzy_Click(object sender, EventArgs e)
        {
            loadform(new kurzy());
        }

        private void bt_live_Click(object sender, EventArgs e)
        {
            loadform(new live());
        }

        private void bt_forum_Click(object sender, EventArgs e)
        {
            loadform(new forum(this.Username));
        }

        private void bt_vysledky_Click(object sender, EventArgs e)
        {
            loadform(new vysledky());
        }

        private void lb_account_Click(object sender, EventArgs e)
        {
            loadform(new account(this.Username,this.Password,this.Mail,this.Id,this,this.menu));
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void toppanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void bt_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
