/*
 * 1. В программу была довалена новая фабрика AudiFacroty.
 * 2. В конфигурацию автомобиля добавлено новое свойство тип кузова.
 * 
 * Абстрактная фабрика позволяет более эффективно добавлять различные
 * вариации продуктов. Например, если нам понадобилось добавить новый
 * абстрактный продукт, необходимо лишь релизовать абстрактный класс и
 * добавить функцию создания этого продукта в фабрику, не влезая во
 * внутренний код уже существующих классов. 
 * 
 */

using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory ford_car = new FordFactory();
            Client c1 = new Client(ford_car);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час",
            c1.ToString(), c1.RunMaxSpeed());


            CarFactory audi = new AudiFactory();
            Client c2 = new Client(audi);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час. Тип кузова - {2}",
                c2.ToString(), c2.RunMaxSpeed(), c2.GetBodyType());
        }
    }
}
