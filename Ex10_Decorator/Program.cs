/*
 * Сравнение паттерна Декоратор с наследованием.
 * 
 * Преимущества декоратора:
 * 1. Предоставляет большую гибкость, чем у наследования
 * 2. Позволяет быстро добавлять новые обязанности
 * 3. Имеет несколько объектов мелких объектов вместо одного
 * 
 * Недостатки:
 * 1. Большое количество маленьких классов
 * 2. Трудно конфигурировать многократно обернутые объекты
 * 
 */


using System;

namespace Ex10_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Renault reno = new Renault("Рено", "Renault LOGAN Active", 499.0);
            Print(reno);
            AutoBase myreno = new MediaNAV(reno, "Навигация");
            Print(myreno);
            AutoBase newmyReno = new SystemSecurity(new MediaNAV(reno, "Навигация"),
           "Безопасность");
            Print(newmyReno);

            Audi audi = new Audi("Ауди", "Audi A8", 1000);

            AutoBase myaudi = new ParkingRadar(
                new HeatSystem(
                new SystemSecurity(
                new MediaNAV(audi, "Навигация"), "Безопасность"), "Система подгорева"), "Парктроник");

            Print(myaudi);
        }
        private static void Print(AutoBase av)
        {
            Console.WriteLine(av.ToString());
        }

    }
}
