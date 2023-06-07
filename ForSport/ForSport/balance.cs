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
    public partial class balance : Form
    {
        private string id, username;
        private float balanse;
        public float Balanse { get => balanse; set => balanse = value; }
        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public balance(string id, string username,float balanse)
        {
            InitializeComponent();
            this.Balanse = balanse;
            this.Username = username;
            this.Id = id;
            bt_addbalance.FlatAppearance.BorderSize = 0;

            lb_balance.Text = $"Tvoj balance je: {this.Balanse.ToString()}";
        }

        private void bt_addbalance_Click(object sender, EventArgs e)
        {
            if (tb_zmena_balance.Text != "" && tb_sprava.Text != "")
            {
                if (tb_sprava.Text.Length <= 200)
                {
                    tb_zmena_balance.Text = round(tb_zmena_balance.Text);
                    if (float.Parse(tb_zmena_balance.Text) <= 10000.0)
                    {
                        string changed = change_to_dot(tb_zmena_balance.Text);
                        string insert_balance_sql = $"INSERT INTO poziadavky (`id`,`username`,`sprava`, `amount`) VALUES(\'{this.Id}\',\'{this.Username}\',\'{tb_sprava.Text}\',{changed})";
                        MySqlCommand insert_balance_command = new MySqlCommand(insert_balance_sql, Database.connection);
                        insert_balance_command.ExecuteNonQuery();
                        tb_zmena_balance.Text = "";
                        tb_sprava.Text = "";
                        MessageBox.Show("Požiadavka uspešna");
                    }
                    else
                    {
                        tb_zmena_balance.Text = "";
                        MessageBox.Show("Prekročil si maximalnu požiadavku");
                    }
                }
                else MessageBox.Show("Správa musí mať menej ako 200 znakov");
                    
            }
            else
            {
                MessageBox.Show("Musiš zadať koľko peňazí chceš pridať a musíš zadať správu, alebo si nezadal správny počet");
            }
        }
        private void tb_zmena_balance_Validating(object sender, CancelEventArgs e)
        {
            float value;
            tb_zmena_balance.Text = change_to_comma(tb_zmena_balance.Text);
            if (!float.TryParse(tb_zmena_balance.Text, out value)) { tb_zmena_balance.Text = ""; }
        }
        private string change_to_comma(string change)
        {
            string new_amount = "";
            change.Trim();
            foreach(char i in change)
            {
                if (i == '.')
                {
                    new_amount = new_amount + ',';
                }
                else new_amount = new_amount + i;
            }
            return new_amount;
        }
        private string change_to_dot(string change)
        {
            string new_amount = "";
            change.Trim();
            foreach (char i in change)
            {
                if (i == ',')
                {
                    new_amount = new_amount + '.';
                }
                else new_amount = new_amount + i;
            }
            return new_amount;
        }
        private string round(string change)
        {
            float new_value = (float)Math.Round(float.Parse(change), 2);
            string new_string = new_value.ToString();
            return new_string;
        }
    }
}
