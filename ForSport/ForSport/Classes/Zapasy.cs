using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSport.Classes
{
    internal class Zapasy
    {

        string tym1;
        string tym2;
        string vysledok1;
        string vysledok2;
        string vysledok;

        public string Tym1 { get => tym1; set => tym1 = value; }
        public string Tym2 { get => tym2; set => tym2 = value; }
        public string Vysledok1 { get => vysledok1; set => vysledok1 = value; }
        public string Vysledok2 { get => vysledok2; set => vysledok2 = value; }
        public string Vysledok { get => vysledok; set => vysledok = value; }

        public Zapasy(string tym1, string tym2, string vysledok1, string vysledok2)
        {
            this.Tym1 = tym1;
            this.Tym2 = tym2;
            this.Vysledok1 = vysledok1;
            this.Vysledok2 = vysledok2;
        }

    }
}
