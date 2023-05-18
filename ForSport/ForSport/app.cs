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

namespace ForSport
{
    public partial class app : Form
    {
        public app()
        {
            InitializeComponent();
            bt_kurzy.FlatAppearance.BorderSize = 0;
            bt_forum.FlatAppearance.BorderSize = 0;
            bt_live.FlatAppearance.BorderSize = 0;
            bt_vysledky.FlatAppearance.BorderSize = 0;
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
            loadform(new forum());
        }

        private void bt_vysledky_Click(object sender, EventArgs e)
        {
            loadform(new vysledky());
        }

        private void btn_exit_Click(object sender, EventArgs e) 
        {
            Environment.Exit(0);
        }
    }
}
