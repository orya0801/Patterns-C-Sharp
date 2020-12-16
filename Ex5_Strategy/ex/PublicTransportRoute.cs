using System;
using System.Collections.Generic;
using System.Text;

namespace Ex5_Strategy.ex
{
    class PublicTransportRoute : StrategyRoute
    {
        public PublicTransportRoute()
        {
            Type = "Маршрут на общественном транспорте";
        }

        public override string ToString()
        {
            return Type;
        }

        public override string BuildRoute(string A, string B)
        {
            return String.Format("***Построение маршрута на общественном " +
                "транспорте из точки {0} в точку {1}***", A, B);
        }
    }
}
