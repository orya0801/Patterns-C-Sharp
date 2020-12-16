using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3_FactoryMethod
{
    abstract class TransportService
    {
        public string Name { get; set; }

        public TransportService(string name)
        {
            Name = name;
        }

        abstract public double CostTransportation(double distance);
    }

    class TaxiServices : TransportService
    {
        public int Category { get; set; }
        public TaxiServices(string name, int cat) : base(name)
        {
            Category = cat;
        }
        public override double CostTransportation(double distance)
        {
            return distance * Category;
        }
        public override string ToString()
        {
            string s = String.Format("Фирма {0}, поездка категории {1}", Name, Category);
            return s;
        }
    }

    class Shipping : TransportService
    {
        public double Tariff { get; set; }
        public Shipping(string name, int taff) : base(name)
        {
            Tariff = taff;
        }
        public override double CostTransportation(double distance)
        {
            return distance * Tariff;
        }
        public override string ToString()
        {
            string s = String.Format("Фирма {0}, доставка по тарифу {1}", Name, Tariff);
            return s;
        }
    }

    class DrunkDriverService : TransportService
    {
        public double Cost { get; set; }

        public DrunkDriverService(string name, int cost) : base(name)
        {
            Cost = cost;
        }

        public override double CostTransportation(double distance)
        {
            return Cost * distance;
        }

        public override string ToString()
        {
            string s = String.Format("Фирма {0}, Услуга \"Пьяный водитель\"", Name);
            return s;
        }
    }
}
