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
    public partial class forum : Form
    {
        public forum()
        {
            InitializeComponent();
            bt_zverejni.FlatAppearance.BorderSize = 0;

            create_comment(0,200);
            create_comment(1,400);
            panel_main.SendToBack();
        }

        private void create_comment(int panel_index, int pos_y)
        {
            Panel dynamicPanel = new Panel();

            dynamicPanel.Location = new System.Drawing.Point(200, pos_y);
            dynamicPanel.Name = $"panel{panel_index}";
            dynamicPanel.Size = new System.Drawing.Size(500, 120);
            dynamicPanel.TabIndex = panel_index; 
            dynamicPanel.BackColor = Color.LightBlue;
            dynamicPanel.BringToFront();
            
            Controls.Add(dynamicPanel);
            
        }
    }
}
