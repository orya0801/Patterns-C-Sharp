using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    abstract class CarFactory
    {
        public abstract AbstractCar CreateCar();
        public abstract AbstractEngine CreateEngine();
        public abstract AbstractBody CreateBody();
    }

    abstract class AbstractCar
    {
        public string Name { get; set; }
        public abstract int MaxSpeed(AbstractEngine engine);

        public string BodyType(AbstractBody body)
        {
            return body.BodyType;
        }
    }

    abstract class AbstractEngine
    {
        public int max_speed { get; set; }
    }

    abstract class AbstractBody
    {
        public string BodyType { get; set; }
    }
}
