using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1_Adapter
{
    class AdapterGame : IGame
    {
        Monet monet;


        public AdapterGame(Monet mon)
        {
            monet = mon;
        }

        public int Brosok()
        {
            return monet.BrosokM();
        }
    }
}
