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
    }
}
