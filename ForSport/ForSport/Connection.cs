using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ForSport
{
    internal class Connection
    { 
        private static string host = "geleta.vybrat.eu";
        private static string databazka = "c46ForSport";
        private static string user = "c46jakub_geleta";
        private static string password = "Jakub2544444";

        public static string info()
        {
            string constring = $"SERVER={host};DATABASE={databazka};UID={user};PASSWORD={password}";
            return constring;
        }
        
    }
}
