using MySql.Data.MySqlClient;
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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            datagrid_users.ForeColor = Color.Black;
            refresh_datagrid();
            
        }

        private void loadform(object Form)
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

        private void datagrid_users_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = "";
            if (datagrid_users.SelectedRows[0].Cells["ID"].Value == null) return;
            else 
            { 
                id = datagrid_users.SelectedRows[0].Cells["ID"].Value.ToString(); 
            }
            loadform(new user_info(id));
        }

        private void refresh_datagrid()
        {
            while (datagrid_users.Rows.Count >= 1)
            {
                foreach (DataGridViewRow row in datagrid_users.Rows)
                {
                    datagrid_users.Rows.Remove(row);
                }
            }

            string sql = $"SELECT username,id FROM user_info WHERE id != \'1111111111\'"; // sql prikaz
            MySqlCommand command = new MySqlCommand(sql, Database.connection); // vytvorenie objektu command

            MySqlDataReader reader = command.ExecuteReader(); // vytvorenie readeru s commandom

            if (!reader.HasRows) // pozrie ci reader nevratil prazdnu tabulku
            {
                reader.Close();
                return;
            }
            while (reader.Read())
            {
                datagrid_users.Rows.Add(reader.GetString("id"), reader.GetString("username"));
            }
            reader.Close();
        }
    }
}
