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
    public partial class admin_poziadavky : Form
    {
        public admin_poziadavky()
        {
            InitializeComponent();
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
            string poziadavka = "";
            if (datagrid_users.SelectedRows[0].Cells["ID"].Value == null) return;
            else
            {
                id = datagrid_users.SelectedRows[0].Cells["ID"].Value.ToString();
                poziadavka = remove(datagrid_users.SelectedRows[0].Cells["pocet"].Value.ToString());
            }
            loadform(new poziadavka(id,poziadavka,this));
        }
        public void refresh_datagrid()
        {
            while (datagrid_users.Rows.Count >= 1)
            {
                foreach (DataGridViewRow row in datagrid_users.Rows)
                {
                    datagrid_users.Rows.Remove(row);
                }
            }

            string sql = $"SELECT * FROM poziadavky"; 
            MySqlCommand command = new MySqlCommand(sql, Database.connection); 

            MySqlDataReader reader = command.ExecuteReader(); 

            if (!reader.HasRows)
            {
                reader.Close();
                return;
            }
            while (reader.Read())
            {
                datagrid_users.Rows.Add(reader.GetString("id"), reader.GetString("username"),reader.GetFloat("amount").ToString() + "€");
            }
            reader.Close();
        }
        private string remove(string remove)
        {
            string new_string = "";
            foreach(char i in remove)
            {
                if (i != '€')
                {
                    new_string += i;
                }
            }
            return new_string;
        }
    }
}
