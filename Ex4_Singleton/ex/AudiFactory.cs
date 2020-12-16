using System;
using System.Collections.Generic;
using System.Text;

namespace Ex4_Singleton.ex
{
    class AudiFactory : CarFactory
    {
        public override AbstractEngine CreateEngine()
        {
            return new AudiEngine();
        }

        public override AbstractCar CreateCar()
        {
            return new AudiCar("Ауди");
        }

        public override AbstractBody CreateBody()
        {
            return new AudiBody();
        }
    }

    class AudiCar : AbstractCar
    {
        public AudiCar(string name)
        {
            Name = name;
        }

        public override int MaxSpeed(AbstractEngine engine)
        {
            return engine.max_speed;
        }

        public override string ToString()
        {
            return "Автомобиль " + Name;
        }
    }

    class AudiEngine : AbstractEngine
    {
        public AudiEngine()
        {
            max_speed = 300;
        }
    }

    class AudiBody : AbstractBody
    {
        public AudiBody()
        {
            BodyType = "Купе";
        }
    }
}
