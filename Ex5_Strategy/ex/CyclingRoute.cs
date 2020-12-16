using System;
using System.Collections.Generic;
using System.Text;

namespace Ex5_Strategy.ex
{
    class CyclingRoute : StrategyRoute
    {
        public CyclingRoute()
        {
            Type = "Маршрут по велодорожкам";
        }

        public override string ToString()
        {
            return Type;
        }

        public override string BuildRoute(string A, string B)
        {
            return String.Format("***Построение маршрута по велодорожкам " +
                "из точки {0} в точку {1}***", A, B);
        }
    }
}
