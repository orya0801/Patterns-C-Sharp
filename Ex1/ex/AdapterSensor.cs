using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1_Adapter.ex
{
    class AdapterSensor : ISensor
    {
        FahrenheitSensor sensor;

        public AdapterSensor(FahrenheitSensor fs)
        {
            sensor = fs;
        }
        public double GetTemperature()
        {
            double ft = sensor.GetFahrenheitTemperature();
            double res = (ft - 32) / 1.8;

            return res;
        }
    }
}
