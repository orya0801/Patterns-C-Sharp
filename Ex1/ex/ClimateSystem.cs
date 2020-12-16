using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1_Adapter.ex
{
    class ClimateSystem
    {
        public string Name { get; set; }

        public ClimateSystem(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public double SeansGame(ISensor s)
        {
            return s.GetTemperature();
        }
    }
}
