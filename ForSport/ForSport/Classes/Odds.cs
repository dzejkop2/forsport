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
    internal class Odds
    {
        int pos_y_Odds;
        string first_team, second_team, date_Odds, kurz1, kurz10, kurz0, kurz02, kurz2;
        Panel panel;

        public Panel Panel { private get => panel; set => panel = value; }
        public int Pos_y_Odds { private get => pos_y_Odds; set => pos_y_Odds = value; }
        public string First_team { private get => first_team; set => first_team = value; }
        public string Second_team { private get => second_team; set => second_team = value; }
        public string Date_Odds { private get => date_Odds; set => date_Odds = value; }
        public string Kurz1 { private get => kurz1; set => kurz1 = value; }
        public string Kurz10 { private get => kurz10; set => kurz10 = value; }
        public string Kurz0 { private get => kurz0; set => kurz0 = value; }
        public string Kurz02 { private get => kurz02; set => kurz02 = value; }
        public string Kurz2 { private get => kurz2; set => kurz2 = value; }

        public Odds(Panel panel, int pos_y_Odds, string first_team, string second_team, string date_Odds, string kurz1, string kurz10, string kurz0, string kurz02, string kurz2)
        {
            this.Panel = panel;
            this.Pos_y_Odds = pos_y_Odds;
            this.First_team = first_team;
            this.Second_team = second_team;
            this.Date_Odds = date_Odds;
            this.Kurz1 = kurz1;
            this.Kurz10 = kurz10;
            this.Kurz0 = kurz0;
            this.Kurz02 = kurz02;
            this.Kurz2 = kurz2;

        }

        public void create_odd()
        {
            Panel main_odds_panel = new Panel();
            main_odds_panel.Location = new System.Drawing.Point(19, 13 + this.Pos_y_Odds);
            main_odds_panel.Size = new System.Drawing.Size(800, 90);
            main_odds_panel.BackColor = Color.FromArgb(207, 233, 250);
            main_odds_panel.BringToFront();
            Panel.Controls.Add(main_odds_panel);

            /*Label lb_name = new Label();
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
            comment_panel.Controls.Add(lb_text);*/

            Label lb_name = new Label();
            lb_name.AutoSize = true;
            lb_name.Text = $"{this.First_team} - {this.Second_team}";
            lb_name.Location = new Point(15, main_odds_panel.Height/2-lb_name.Height/2);
            lb_name.ForeColor = Color.FromArgb(0, 92, 178);
            lb_name.Font = new Font("Microsoft Sans Serif", 16);
            main_odds_panel.Controls.Add(lb_name);

            Label lb_date = new Label();
            lb_date.AutoSize = true;
            lb_date.Text = this.Date_Odds;
            lb_date.Location = new Point(main_odds_panel.Width/2-lb_date.Width, main_odds_panel.Height / 2 - lb_date.Height/2);
            lb_date.ForeColor = Color.FromArgb(0,0,0);
            lb_date.Font = new Font("Microsoft Sans Serif", 13);
            main_odds_panel.Controls.Add(lb_date);

            Button btn_kurz1 = new Button();
            btn_kurz1.Size = new Size(55, 30);
            btn_kurz1.Text = this.Kurz1;
            btn_kurz1.ForeColor = Color.FromArgb(0, 92, 178);
            btn_kurz1.BackColor = Color.Red;
            btn_kurz1.Location = new Point(main_odds_panel.Width-286, main_odds_panel.Height / 2 - btn_kurz1.Height / 2);
            btn_kurz1.Font = new Font("Microsoft Sans Serif", 12);
            main_odds_panel.Controls.Add(btn_kurz1);

            Button btn_kurz10 = new Button();
            btn_kurz10.Size = new Size(55, 30);
            btn_kurz10.Text = this.Kurz10;
            btn_kurz10.ForeColor = Color.FromArgb(0, 92, 178);
            btn_kurz10.Location = new Point(main_odds_panel.Width - 229, main_odds_panel.Height / 2 - btn_kurz10.Height / 2);
            btn_kurz10.Font = new Font("Microsoft Sans Serif", 12);
            main_odds_panel.Controls.Add(btn_kurz10);

            Button btn_kurz0 = new Button();
            btn_kurz0.Size = new Size(55, 30);
            btn_kurz0.Text = this.Kurz0;
            btn_kurz0.ForeColor = Color.FromArgb(0, 92, 178);
            btn_kurz0.Location = new Point(main_odds_panel.Width - 172, main_odds_panel.Height / 2 - btn_kurz0.Height / 2);
            btn_kurz0.Font = new Font("Microsoft Sans Serif", 12);
            main_odds_panel.Controls.Add(btn_kurz0);

            Button btn_kurz02 = new Button();
            btn_kurz02.Size = new Size(55, 30);
            btn_kurz02.Text = this.Kurz02;
            btn_kurz02.ForeColor = Color.FromArgb(0, 92, 178);
            btn_kurz02.Location = new Point(main_odds_panel.Width - 115, main_odds_panel.Height / 2 - btn_kurz02.Height / 2);
            btn_kurz02.Font = new Font("Microsoft Sans Serif", 12);
            main_odds_panel.Controls.Add(btn_kurz02);

            Button btn_kurz2 = new Button();
            btn_kurz2.Size = new Size(55, 30);
            btn_kurz2.Text = this.Kurz2;
            btn_kurz2.ForeColor = Color.FromArgb(0, 92, 178);
            btn_kurz2.Location = new Point(main_odds_panel.Width - 58, main_odds_panel.Height/2-btn_kurz2.Height/2);
            btn_kurz2.Font = new Font("Microsoft Sans Serif", 12);
            main_odds_panel.Controls.Add(btn_kurz2);
        }

        
    }
}
