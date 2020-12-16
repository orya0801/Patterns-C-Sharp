using System;
using System.Collections.Generic;
using System.Text;

namespace Ex10_Decorator
{
    class Renault : AutoBase
    {
        public Renault(string name, string info, double costbase)
        {
            Name = name;
            Description = info;
            CostBase = costbase;
        }

        public override double GetCost()
        {
            return CostBase * 1.18;
        }
    }
}
