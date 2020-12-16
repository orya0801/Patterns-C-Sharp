/*
 * Шаблонный метод позволяет расширять базовый алгоритм в подклассах, 
 * не меняя его структуры. Данный паттерн применим в ситуациях, когда
 * есть несколько классов, делающих одно и то же с незначительными отличиями.
 * 
 */

using System;
using Ex6_TemplateMethod.ex;

namespace Ex6_TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("First = ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("Last = ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("H = ");
            int h = int.Parse(Console.ReadLine());

            //Progression prog1 = new ArithmeticProgression(f, l, h);
            //prog1.TemplateMethod();

            Progression prog2 = new GeometricProgression(f, l, h);
            prog2.TemplateMethod();
            */

            Pokemon pokemon1 = new GroundPokemon("Сэндшру", 10, 100, 80);
            Console.WriteLine(pokemon1);
            pokemon1.CalculateDamage();

            Pokemon pokemon2 = new WaterPokemon("Сквиртл", 10, 92, 86);
            Console.WriteLine(pokemon2);
            pokemon2.CalculateDamage();
        }
    }
}
