using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForSport.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ForSport
{

    public partial class teams : Form
    {
        List<Teams> tymy = new List<Teams>();
        public teams()
        {
            InitializeComponent();
            get_teams();
            load_DG();
        }

        private void get_teams()
        {
            tymy.Clear();
            string sql = $"SELECT * FROM tymy ORDER BY body DESC";
            MySqlCommand command = new MySqlCommand(sql, Database.connection);
            MySqlDataReader reader = command.ExecuteReader();

            if (!reader.HasRows)
            {
                reader.Close();
                return;
            }
            while (reader.Read())
            {
                tymy.Add(new Teams(reader.GetString("nazov"), reader.GetInt32("body")));
            }
            reader.Close();
        }
        private void load_DG()
        {
            dataGridView1.Rows.Clear();
            foreach (Teams t in tymy)
            {
                dataGridView1.Rows.Add(t.Name, t.Points);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != string.Empty)
            {
                get_teams();
                foreach (Teams t in tymy)
                {
                    if (t.Name == textBox1.Text)
                    {
                        MessageBox.Show("Tento tým už existuje!");
                        return;
                    }
                }
                string sql = $"INSERT INTO tymy (`nazov`, `body`) VALUES(\'{textBox1.Text}\', \'0\')";
                MySqlCommand command = new MySqlCommand(sql, Database.connection);
                command.ExecuteNonQuery();
                get_teams();
                load_DG();
            }
            else
            {
                MessageBox.Show("Pole nemôže byť prázdne!");
                return;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() != string.Empty)
            {
                string sql = $"DELETE FROM tymy WHERE nazov=\'{textBox2.Text}\'";
                MySqlCommand command = new MySqlCommand(sql, Database.connection);
                command.ExecuteNonQuery();
                get_teams();
                load_DG();
            }
            else
            {
                MessageBox.Show("Pole nemôže byť prázdne!");
                return;
            }
        }
    }
}
