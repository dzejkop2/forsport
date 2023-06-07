using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSport.Classes
{
    internal class Pavuk
    {
        private string meno;
        private string vysledok;

        public string Meno { get => meno; set => meno = value; }
        public string Vysledok { get => vysledok; set => vysledok = value; }

        public Pavuk(string meno)
        {
            this.meno = meno;
            this.vysledok = "";
        }
    }
}
