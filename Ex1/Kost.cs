using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1_Adapter
{
    class Kost : IGame
    {
        Random r;

        public Kost()
        {
            r = new Random();
        }

        public int Brosok()
        {
            int res = r.Next(6) + 1;
            return res;
        }
    }
}
