using ForSport.Classes;
using MySql.Data.MySqlClient;
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
        string username;
        public string Username { get => username; set => username = value; }

        List<Comments> comments = new List<Comments>();
        DateTime current_date = DateTime.Now;
        public forum(string username)
        {
            InitializeComponent();
            bt_zverejni.FlatAppearance.BorderSize = 0;
            get_comments();
            this.Username = username;
            foreach (Comments comment in comments)
            {
                comment.create_comment();
            }
        }

        private void bt_zverejni_Click(object sender, EventArgs e)
        {
            if(tb_sprava.Text != "")
            {
                if (tb_sprava.Text.Length != 200)
                { 
                    publish_comment(this.Username, tb_sprava.Text, current_date.ToString());
                    panel_main.Controls.Clear();
                    comments.Clear();
                    get_comments();
                    foreach (Comments comment in comments)
                    {
                        comment.create_comment();
                    }
                }
                else
                {
                    MessageBox.Show("Sprava musi byt mensia ako 200 znakov");
                }
            }
            else
            {
                MessageBox.Show("Musis zadat spravu ktoru chces poslat");
            }
        }

        private void publish_comment(string username, string text, string date)
        {
            string sql = $"INSERT INTO forum (`username`, `comment`, `date`) VALUES('{username}', '{text}', '{date}')";
            MySqlCommand command = new MySqlCommand(sql, Database.connection);
            command.ExecuteNonQuery();
        }

        private void get_comments()
        {
            int pos = 0;
            string sql = $"SELECT * FROM forum";
            MySqlCommand command = new MySqlCommand(sql, Database.connection);
            MySqlDataReader reader = command.ExecuteReader();

            if (!reader.HasRows)
            {
                reader.Close();
                return;
            }
            while (reader.Read())
            {
                comments.Add(new Comments(panel_main, pos, reader.GetString("username"), reader.GetString("date"), reader.GetString("comment")));
                pos = pos + 100;
            }
            reader.Close();
        }
    }
}
