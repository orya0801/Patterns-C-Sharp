/*
 * Паттерн Command применим в следующих случаях:
 * 1. Когда есть необходимость параметризовать объекты выполняемым действием
 * 2. Когда надо ставить операции в очередь или выполнять их по расписанию
 * 3. Когда необходимо реализовать операцию отмены
 * 
 */

using System;

namespace Ex9_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            double result = 0;
            result = calculator.Add(5);
            Console.WriteLine(result);
            result = calculator.Multiply(6);
            Console.WriteLine(result);
            result = calculator.Div(3);
            Console.WriteLine(result);
            result = calculator.Redo();
            Console.WriteLine(result);
            result = calculator.Undo(1);
            Console.WriteLine(result);
        }
    }
}
