using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSport.Classes
{
    internal class Pavuk
    {
        private string name;
        private int points;
        private string postup;

        public string Name { get => name; set => name = value; }
        public int Points { get => points; set => points = value; }
        public string Postup { get => postup; set => postup = value; }

        public Pavuk(string name, int points, string postup)
        {
            this.name = name;
            this.points = points;
            this.postup = postup;
        }
    }
}
