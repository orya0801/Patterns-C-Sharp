/*
 * В качестве упражнения на использование паттерна Singleton был изменен код
 * конктретной фабрики FordFactory из второго упражнения. После изменения кода
 * в программе используется только один экземпляр объекта класса AudiFactory и  
 * есть гарантия того, что этот экземпляр доступен.
 */


using System;
using Ex4_Singleton.ex;

namespace Ex4_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Log lg = Log.MyLog;
            lg.LogExecution("Метод Main()");

            double op = Operation.Run('-', 35);
            op = Operation.Run('+', 30);


            CarFactory ford_car = FordFactory.MyFordFactory;
            Client c1 = new Client(ford_car);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час",
            c1.ToString(), c1.RunMaxSpeed());
        }
    }
}
