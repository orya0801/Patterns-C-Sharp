using System;
using System.Collections.Generic;
using System.Text;

namespace Ex10_Decorator
{
    class Audi : AutoBase
    {
        public Audi(string name, string info, double costbase)
        {
            Name = name;
            Description = info;
            CostBase = costbase;
        }

        public override double GetCost()
        {
            return CostBase * 1.5;
        }
    }
}
