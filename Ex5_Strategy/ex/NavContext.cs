using System;
using System.Collections.Generic;
using System.Text;

namespace Ex5_Strategy.ex
{
    class NavContext
    {
        StrategyRoute strategy;
        public NavContext(StrategyRoute strategy)
        {
            this.strategy = strategy;
        }

        public override string ToString()
        {
            return strategy.ToString();
        }

        public string BuildRoute(string A, string B)
        {
            return strategy.BuildRoute(A, B);
        }

        public void ShowMap()
        {
            Console.WriteLine("***Карта***");
        }

        public void FindPoint(string A)
        {
            Console.WriteLine("***Нахождение точки {0} на карте***", A);
        }
    }
}
