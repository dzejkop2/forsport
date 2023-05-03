using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForSport
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            string host = "geleta.vybrat.eu";
            string databazka = "c46ForSport";
            string user = "c46jakub_geleta";
            string password = "Jakub2544444";
            string constring = "SERVER=" + host + ";" + "DATABASE=" + databazka + ";" + "UID=" + user + ";" + "PASSWORD=" + password;
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            string command = "select * from test123";
            MySqlCommand cmd = new MySqlCommand(command, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            

        }
    }
}
