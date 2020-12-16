using System;
using System.Collections.Generic;
using System.Text;

namespace Ex5_Strategy.ex
{
    class RoadRoute : StrategyRoute
    {
        public RoadRoute()
        {
            Type = "Маршрут на машине";
        }

        public override string ToString()
        {
            return Type;
        }

        public override string BuildRoute(string A, string B)
        {
            return String.Format("***Построение маршрута по дорогам " +
                "из точки {0} в точку {1}***", A, B);
        }
    }
}
