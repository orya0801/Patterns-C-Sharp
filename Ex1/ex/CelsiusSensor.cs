using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1_Adapter.ex
{
    class CelsiusSensor : ISensor
    {
        Random r;

        public CelsiusSensor()
        {
            r = new Random();
        }

        public double GetTemperature()
        {
            return r.Next(50) - 25 + r.NextDouble();
        }
    }
}
