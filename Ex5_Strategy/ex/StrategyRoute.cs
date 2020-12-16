using System;
using System.Collections.Generic;
using System.Text;

namespace Ex5_Strategy.ex
{
    abstract class StrategyRoute 
    {
        public string Type { get; set; }

        public abstract string BuildRoute(string A, string B);
    }
}
