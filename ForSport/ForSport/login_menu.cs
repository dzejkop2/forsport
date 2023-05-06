using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "";
            string password = "";
            Login login = new Login(name, password);
        }

    }
}
