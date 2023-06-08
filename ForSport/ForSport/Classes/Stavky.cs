using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSport.Classes
{
    internal class Stavky
    {
        private string id;
        private string vysledok;
        private string vyhra;
        private string tym;

        public string Id { get => id; set => id = value; }
        public string Vysledok { get => vysledok; set => vysledok = value; }
        public string Vyhra { get => vyhra; set => vyhra = value; }
        public string Tym { get => tym; set => tym = value; }

        public Stavky(string id,string tym, string vysledok, string vyhra)
        {
            this.id = id;
            this.vysledok = vysledok;
            this.vyhra = vyhra;
            this.tym = tym;
        }

        void Stavka()
        {
            
        }


    }
}
