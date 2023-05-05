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
        public Form1()
        { 
            InitializeComponent();
        }
        
        static string constring = "SERVER=usa.vybrat.eu;PORT=3306;DATABASE=c46ForSport;UID=c46forsport;PASSWORD=ForSport123456;";

        private void button1_Click(object sender, EventArgs e)
        { 
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = constring;
            conn.Open();
            MessageBox.Show("Connection Open!");
            conn.Close();
        }
    }
}
