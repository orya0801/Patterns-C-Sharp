using System;
using System.Collections.Generic;
using System.Text;

namespace Ex5_Strategy.ex
{
    class WalkingRoute : StrategyRoute
    {
        public WalkingRoute()
        {
            Type = "Пеший маршрут";
        }

        public override string ToString()
        {
            return Type;
        }

        public override string BuildRoute(string A, string B)
        {
            return String.Format("***Построение пешевого маршрута " +
                "из точки {0} в точку {1}***", A, B);
        }
    }
}
