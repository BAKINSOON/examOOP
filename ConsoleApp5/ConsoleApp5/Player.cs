using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Player
    {
        public string Name { get; set; }

        public string Rang { get; set; }

        public Cord OnPlayedCord { get; set; }

        public Player(string Rang, string Name)
        {
            this.Rang = Rang;
            this.Name = Name;
        }
    }
}
