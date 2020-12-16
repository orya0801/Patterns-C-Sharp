/*
 * Задание: В разработанное приложение добавьте поддержку новой услуги, 
 * например, «пьяный водитель». 
 * 
 * Решение:
 * 1. Добавлена услуга DrunkDriverService, унаследованная от TransportService.
 * 2. Добавлен класс-создатель DrunkDriverCom для услуги DrunkDriverService
 * 
 * Паттерн "Фабричный метод"  отделяет код производства продуктов от остального кода,
 * которые использует эти продукты, что позволяет расширять код производства, не затрагивая
 * основной код.
 * 
 */


using System;

namespace Ex3_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportCompany trCom = new TaxiTransCom("Служба такси");
            TransportService compService = trCom.Create("Такси", 1);
            
            double dist = 15.5;

            Print(compService, dist);

            TransportCompany gCom = new ShipTransCom("Служба перевозок");
            compService = gCom.Create("Грузоперевозки", 2);

            double distg = 150.5;
            Print(compService, distg);

            TransportCompany ddCom = new DrunkDriverCom("Служба Drunk Driver");
            compService = ddCom.Create("Drunk Driver", 5);

            Print(compService, 50);
        }
        private static void Print(TransportService compTax, double distg)
        {
            Console.WriteLine("Компания {0}, расстояние {1}, стоимость: {2}",
            compTax.ToString(), distg, compTax.CostTransportation(distg));
        }
    }
}
