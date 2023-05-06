using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ForSport
{
    internal class Database
    {
        MySqlConnection conn = new MySqlConnection("SERVER=usa.vybrat.eu;PORT=3306;DATABASE=c46ForSport;UID=c46forsport;PASSWORD=byxB@iNT47;"); // vytvorenie samotneho pripojenia
        public void connect() // metoda na pripojenie do DB
        {
            try // skusi sa otvorit connection
            {
                conn.Open(); // otvorenie spojenia s DB
                MessageBox.Show("Pripojenie uspesne"); // placeholder text na debugovanie
            }
            catch(Exception e) // ak sa nepodari vyhodi sa messagebox a connection sa zavrie
            {
                MessageBox.Show("Nepodarilo sa pripojit na databazu"); // placeholder text na debugovanie
                conn.Close(); // zatvorenie spojenia s DB
            }
        }
        public void disconnect() // metoda na odpojenie z DB, mozno bude na nic
        {
            conn.Close(); // zatvorenie pripojenia ku DB
            MessageBox.Show("Odpojil si sa z databazy"); // placeholder text na debugovanie
        }
    }
}
