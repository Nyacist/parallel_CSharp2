using System;
using System.Threading.Tasks;

namespace lab2
{
    public class ParallelArraySum
    {
        public static async Task RunAsync()
        {
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
                array[i] = i + 1;

            int mid = array.Length / 2;

            Task<int> firstPartTask = Task.Run(() =>
            {
                return SumArray(array, 0, mid);
            });

            Task<int> secondPartTask = Task.Run(() =>
            {
                return SumArray(array, mid, array.Length);
            });

            await Task.WhenAll(firstPartTask, secondPartTask);

            int totalSum = firstPartTask.Result + secondPartTask.Result;

            Console.WriteLine($"Сумма первой части: {firstPartTask.Result}");
            Console.WriteLine($"Сумма второй части: {secondPartTask.Result}");
            Console.WriteLine($"Общая сумма массива: {totalSum}");
        }

        private static int SumArray(int[] array, int start, int end)
        {
            int sum = 0;
            for (int i = start; i < end; i++)
                sum += array[i];
            return sum;
        }
    }
}
