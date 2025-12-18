using System;
using System.Threading.Tasks;

namespace lab2
{
    public class ParallelGreetings
    {
        public static async Task RunAsync()
        {
            Task t1 = Task.Run(() =>
            {
                Console.WriteLine("Привет из задачи 1");
            });

            Task t2 = Task.Run(() =>
            {
                Console.WriteLine("Привет из задачи 2");
            });

            Task t3 = Task.Run(() =>
            {
                Console.WriteLine("Привет из задачи 3");
            });

            await Task.WhenAll(t1, t2, t3);
        }
    }
}
