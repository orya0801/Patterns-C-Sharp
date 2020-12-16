using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1_Adapter
{
    class Gamer
    {
        public string Name { get; set; }

        public Gamer(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public int SeansGame(IGame ig)
        {
            return ig.Brosok();
        }
    }
}
