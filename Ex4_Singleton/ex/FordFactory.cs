using System;
using System.Collections.Generic;
using System.Text;

namespace Ex4_Singleton.ex
{
    class FordFactory : CarFactory
    {
        static Lazy<FordFactory> myFordFactory = new Lazy<FordFactory>(() => new FordFactory());
        
        public static FordFactory MyFordFactory
        {
            get
            {
                return myFordFactory.Value;
            }
        }
        
        FordFactory() { }

        public override AbstractCar CreateCar()
        {
            return new FordCar("Форд");
        }

        public override AbstractEngine CreateEngine()
        {
            return new FordEngine();
        }

        public override AbstractBody CreateBody()
        {
            return new FordBody();
        }
    }

    class FordCar : AbstractCar
    {
        public FordCar(string name)
        {
            Name = name;
        }
        public override int MaxSpeed(AbstractEngine engine)
        {
            int ms = engine.max_speed;
            return ms;
        }

        public override string ToString()
        {
            return "Автомобиль " + Name;

        }
    }
    class FordEngine : AbstractEngine
    {
        public FordEngine()
        {
            max_speed = 220;
        }
    }

    class FordBody : AbstractBody
    {
        public FordBody()
        {
            BodyType = "Седан";
        }
    }
}
