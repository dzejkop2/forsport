using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ForSport
{
    public partial class Form1 : Form
    {
        void read(string column, string table, string data)
        {
            Connection con = new Connection();
            string constring = Connection.info();
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string sql = $"select * from {table}";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                data = reader.GetString(column);
            }

        }
        public Form1()
        {
            InitializeComponent();
            string data = "";
            read("12","test123", data);
            label1.Text = data;
        }
    }
}
