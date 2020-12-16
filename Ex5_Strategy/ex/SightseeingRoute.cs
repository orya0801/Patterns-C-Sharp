using System;
using System.Collections.Generic;
using System.Text;

namespace Ex5_Strategy.ex
{
    class SightseeingRoute : StrategyRoute
    {
        public SightseeingRoute()
        {
            Type = "Маршрут по достопримечательностям";
        }

        public override string ToString()
        {
            return Type;
        }

        public override string BuildRoute(string A, string B)
        {
            return String.Format("***Маршут от достопримечательности {0} до " +
                "достопримечательности {1}***", A, B);
        }
    }
}
