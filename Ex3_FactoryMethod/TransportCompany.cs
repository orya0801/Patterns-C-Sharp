using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3_FactoryMethod
{
    abstract class TransportCompany
    {
        public string Name { get; set; }
        public TransportCompany(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        abstract public TransportService Create(string name, int k);
    }

    class TaxiTransCom : TransportCompany
    {
        public TaxiTransCom(string name) : base(name) { }
        public override TransportService Create(string n, int c)
        {
            return new TaxiServices(Name, c);
        }

    }

    class ShipTransCom : TransportCompany
    {
        public ShipTransCom(string name) : base(name) { }
        public override TransportService Create(string n, int t)
        {
            return new Shipping(Name, t);
        }
    }

    class DrunkDriverCom : TransportCompany
    {
        public DrunkDriverCom(string name) : base(name) { }
        public override TransportService Create(string n, int t)
        {
            return new Shipping(Name, t);
        }
    }
}
