using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1_Adapter.ex
{
    class FahrenheitSensor
    {
        Random r;

        public FahrenheitSensor()
        {
            r = new Random();
        }

        public double GetFahrenheitTemperature()
        {
            return r.Next(50) + r.NextDouble();
        }
    }
}
