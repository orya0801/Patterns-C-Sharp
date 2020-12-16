/*
 * Задание:
 * Примените паттерн «Стратегия» для проектирования сложного алгоритма 
 * приложения навигатора. Оно должно иметь возможность показывать карту, 
 * реализовывать поиск и прокладку маршрута по автодорогам, пеших маршрутов, 
 * маршрутов по велодорожкам, на общественном транспорте, а также маршруты 
 * посещения достопримечательностей. Конкретно алгоритмы можно 
 * не реализовывать, только спроектировать общую структуру классов.
 * 
 * В данном случае, схожие алгоритмы будут иметь способы построения 
 * различных маршрутов. Поэтому была реализована стратегия RouteStrategy,
 * которая определяет и объединяет список схожих алгоритмов.
 */



using System;
using Ex5_Strategy.ex;


namespace Ex5_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 31, 15, 10, 2, 4, 2, 14, 23, 12, 66 };
            StrategySort sort = new SelectionSort();
            Context context = new Context(sort, arr1);

            context.Sort();
            context.PrintArray();

            int[] arr2 = { 1, 5, 10, 2, 4, 12, 14, 23, 12, 66 };
            sort = new InsertionSort();
            context = new Context(sort, arr2);
            context.Sort();
            context.PrintArray();


            int[] arr3 = { 31, 15, 10, 2, 4, 2, 14, 23, 12, 66 };
            sort = new BubbleSort();
            context = new Context(sort, arr3);

            context.Sort();
            context.PrintArray();


            string A = "A", B = "B";

            StrategyRoute route1 = new CyclingRoute();
            StrategyRoute route2 = new PublicTransportRoute();
            StrategyRoute route3 = new RoadRoute();
            StrategyRoute route4 = new WalkingRoute();
            StrategyRoute route5 = new SightseeingRoute();

            NavContext navContext = new NavContext(route1);
            Console.WriteLine(navContext.ToString() + "\n" + navContext.BuildRoute(A, B) + "\n");

            navContext = new NavContext(route2);
            Console.WriteLine(navContext.ToString() + "\n" + navContext.BuildRoute(A, B) + "\n");

            navContext = new NavContext(route3);
            Console.WriteLine(navContext.ToString() + "\n" + navContext.BuildRoute(A, B) + "\n");

            navContext = new NavContext(route4);
            Console.WriteLine(navContext.ToString() + "\n" + navContext.BuildRoute(A, B) + "\n");

            navContext = new NavContext(route5);
            Console.WriteLine(navContext.ToString() + "\n" + navContext.BuildRoute(A, B) + "\n");
        }
    }
}
