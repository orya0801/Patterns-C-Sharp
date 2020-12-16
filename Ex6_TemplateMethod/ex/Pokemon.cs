using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6_TemplateMethod.ex
{
    abstract class Pokemon
    {
        public string Name { get; set; }
        public double Power { get; set; }
        public double Attack { get; set; }
        public double Defense { get; set; }

        public Pokemon(string name, double p, double a, double d)
        {
            Name = name;
            Power = p;
            Attack = a;
            Defense = d;
        }

        public override string ToString()
        {
            return $"{this.Name}\nСила: {this.Power}\nАтака: {this.Attack}\n" +
                $"Защита: {this.Defense}";
        }

        // Template Method
        public void CalculateDamage()
        {
            var multipliers = CalculateMultiplier();
            var damage = CalculateImpact(multipliers);
            PrintDamage(damage);
        }

        private double CalculateMultiplier()
        {
            Random r = new Random();
            return 0.5 * Power * (r.Next(100) + 1);
        }

        private void PrintDamage(double damage)
        {
            Console.WriteLine($"Pokemon {Name} damage is {damage}\n");
        }

        public abstract double CalculateImpact(double multipliers);
    }
}
