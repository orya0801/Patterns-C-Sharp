using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6_TemplateMethod.ex
{
    class GroundPokemon : Pokemon
    {
        public GroundPokemon(string name, double p, double a, double d) : base(name, p, a, d) { }

        public override double CalculateImpact(double multipliers)
        {
            return ( 2 * Attack / Defense) * multipliers + 10;
        }
    }

    class WaterPokemon : Pokemon
    {
        public WaterPokemon(string name, double p, double a, double d) : base(name, p, a, d) { }
        public override double CalculateImpact(double multipliers)
        {
            return (Attack - Defense) * multipliers + 20;
        }
    }
}
