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
    public partial class register : Form
    {
        private login_menu menu;
        public register(login_menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }
    }
}
