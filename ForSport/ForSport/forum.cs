using ForSport.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ForSport
{
    public partial class forum : Form
    {
        public forum()
        {
            InitializeComponent();
            bt_zverejni.FlatAppearance.BorderSize = 0;
            List<Comments> comments = new List<Comments>();
            comments.Add(new Comments(panel_main, 0, 0, "Robik", "30.4.1945", "sak ty povedz ne"));
            comments.Add(new Comments(panel_main, 1, 100, "pupino", "30.4.1945", "sak ty ne ja som povedal"));

            foreach (Comments comment in comments)
            {
                comment.create_comment();
            }
        }

        private void forum_load(object sender, EventArgs e)
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
