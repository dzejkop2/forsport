using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ForSport.Classes
{
    internal class IdGenerator
    {
        public string id { get; private set; } // property pre id kde sa na konci metody zapise

        private char[] characters = { 'a', 'b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','r','s','t','u','v','w','x','y','z',
                                'A', 'B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','R','S','T','U','V','W','X','Y','Z',
                                '1','2','3','4','5','6','7','8','9','0'}; // array znakov z ktoreho metoda berie

        public void new_id() // vygenerovanie id
        {
            string id = ""; // id zaciatocny string

            int max = Enumerable.Count(characters); // spocita kolko je v array znakov

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                int index = rnd.Next(0, max); // vygeneruje cislo od 0 po pocet znakov v arrayi
                id += characters[index]; // prida vygenerovany znak do id
            }

            this.id = id; // zada id do property classy
        }

    }
}
