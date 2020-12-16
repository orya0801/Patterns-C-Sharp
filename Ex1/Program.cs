/*
 * В качестве упражнения был разработан адаптер, преобразующий
 * температуру в шкалу Цельсия.
 * 
 * С помощью адаптера можно использовать сторонний класс, интерфейс которого
 * не соответствует остальному коду приложения. Адаптер отделяет и скриывает от
 * клиента преобразования различных интерфейсов.
 * 
 */


using System;
using Ex1_Adapter.ex;

namespace Ex1_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Kost kubik = new Kost();
            Gamer g1 = new Gamer("Даниил");
            Console.WriteLine("Выпало очков {0} для игрока {1}",
                g1.SeansGame(kubik), g1.ToString());

            Monet mon = new Monet();
            IGame bmon = new AdapterGame(mon);
            Console.WriteLine("Монета показала \"{0}\" для игрока {1}", g1.SeansGame(bmon),
                g1.ToString());

            ClimateSystem system = new ClimateSystem("Система климат-контроля");
            FahrenheitSensor fs = new FahrenheitSensor();
            ISensor sensor = new AdapterSensor(fs);

            Console.WriteLine("\n[Log]\t{0}.\tТемпература в цельсиях = {1}", system, sensor.GetTemperature().ToString("0.00"));
        }
    }
}
