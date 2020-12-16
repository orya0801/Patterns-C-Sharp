using System;
using System.Collections.Generic;
using System.Text;

namespace Ex10_Decorator
{
    abstract class AutoBase
    {
        public string Name { get; set; }                                                                                                                   
        public string Description { get; set; }
        public double CostBase { get; set; }

        public abstract double GetCost();

        public override string ToString()
        {
            string s = String.Format("Ваш автомобиль: {0}\nОписание: {1}\nСтоимость: {2}\n", Name, Description, GetCost());
            return s;
        }
    }
}
