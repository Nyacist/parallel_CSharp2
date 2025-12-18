using System;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("===== ЗАДАЧА 1: Параллельный вывод сообщений =====");
            await ParallelGreetings.RunAsync();

            Console.WriteLine("\n===== ЗАДАЧА 2: Параллельные вычисления =====");
            await ParallelCalculations.RunAsync();

            Console.WriteLine("\n===== ЗАДАЧА 3: Параллельная обработка массива =====");
            await ParallelArraySum.RunAsync();

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
