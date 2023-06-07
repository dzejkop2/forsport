using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSport.Classes
{
    internal class Teams
    {
        private string name;
        private int points;

        public string Name { get => name; set => name = value; }
        public int Points { get => points; set => points = value; }

        public Teams(string name, int points)
        {
            this.name = name;
            this.points = points;
        }
    }
}
