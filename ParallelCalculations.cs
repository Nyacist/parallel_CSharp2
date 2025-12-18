using System;
using System.Threading.Tasks;

namespace lab2
{
    public class ParallelCalculations
    {
        public static async Task RunAsync()
        {
            Task<long> factorialTask = Task.Run(() =>
            {
                return Factorial(10);
            });

            Task<long> sumTask = Task.Run(() =>
            {
                return Sum(1, 100);
            });

            await Task.WhenAll(factorialTask, sumTask);

            Console.WriteLine($"Факториал 10 = {factorialTask.Result}");
            Console.WriteLine($"Сумма чисел от 1 до 100 = {sumTask.Result}");
        }

        private static long Factorial(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
                result *= i;
            return result;
        }

        private static long Sum(int from, int to)
        {
            long result = 0;
            for (int i = from; i <= to; i++)
                result += i;
            return result;
        }
    }
}
