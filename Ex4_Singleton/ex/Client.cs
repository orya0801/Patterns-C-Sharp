using System;
using System.Collections.Generic;
using System.Text;

namespace Ex4_Singleton.ex
{
    class Client
    {
        private AbstractCar abstractCar;
        private AbstractEngine abstractEngine;
        private AbstractBody abstractBody;
        public Client(CarFactory car_factory)
        {
            abstractCar = car_factory.CreateCar();
            abstractEngine = car_factory.CreateEngine();
            abstractBody = car_factory.CreateBody();
        }
        public int RunMaxSpeed()
        {
            return abstractCar.MaxSpeed(abstractEngine);
        }

        public string GetBodyType()
        {
            return abstractCar.BodyType(abstractBody);
        }

        public override string ToString()
        {
            return abstractCar.ToString();
        }
    }
}
