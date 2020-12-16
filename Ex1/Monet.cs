using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1_Adapter
{
    class Monet
    {
        Random r;

        public Monet()
        {
            r = new Random();
        }

        public int BrosokM()
        {
            int res = r.Next(2) + 1;
            return res;
        }
    }
}
