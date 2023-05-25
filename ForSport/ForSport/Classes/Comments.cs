using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForSport.Classes
{
    internal class Comments
    {
        int pos_y;
        string name, date, text;
        Panel panel;

        public Panel Panel { private get => panel; set => panel = value; }
        public int Pos_y { private get => pos_y; set => pos_y = value; }
        public string Name { private get => name; set => name = value; }
        public string Date { private get => date; set => date = value; }
        public string Text { private get => text; set => text = value; }

        public Comments(Panel panel, int pos_y, string name, string date, string text)
        {
            this.Panel = panel;
            this.Pos_y = pos_y;
            this.Name = name;
            this.Date = date;
            this.Text = text;
        }

        public void create_comment()
        { 
            Panel main_comment_panel = new Panel();
            main_comment_panel.Location = new System.Drawing.Point(19, 13 + this.Pos_y);
            main_comment_panel.Size = new System.Drawing.Size(800, 90);
            main_comment_panel.BackColor = Color.FromArgb(207, 233, 250);
            main_comment_panel.BringToFront();
            Panel.Controls.Add(main_comment_panel);

            Label lb_name = new Label();
            lb_name.Text = this.Name;
            lb_name.Location = new Point(3, 10);
            lb_name.ForeColor = Color.FromArgb(46, 124, 196);
            lb_name.Font = new Font("Microsoft Sans Serif", 12);
            main_comment_panel.Controls.Add(lb_name);

            Label lb_date = new Label();
            lb_date.Text = this.Date;
            lb_date.Location = new Point(main_comment_panel.Size.Width - 130, 10);
            lb_date.Size = new System.Drawing.Size(150, 20);
            lb_date.ForeColor = Color.FromArgb(0, 0, 0);
            lb_date.Font = new Font("Microsoft Sans Serif", 9);
            main_comment_panel.Controls.Add(lb_date);

            Panel comment_panel = new Panel();
            comment_panel.Location = new System.Drawing.Point(7, 34);
            comment_panel.Size = new System.Drawing.Size(main_comment_panel.Size.Width - 30, 43);
            comment_panel.BackColor = Color.FromArgb(233, 248, 253);
            comment_panel.BringToFront();
            main_comment_panel.Controls.Add(comment_panel);

            Label lb_text = new Label();
            lb_text.Text = this.Text;
            lb_text.Location = new Point(5, 5);
            lb_text.ForeColor = Color.FromArgb(0, 0, 0);
            lb_text.Size = new Size(comment_panel.Size.Width, comment_panel.Size.Height);
            lb_text.Font = new Font("Microsoft Sans Serif", 10);
            comment_panel.Controls.Add(lb_text);
        }
    }
}
