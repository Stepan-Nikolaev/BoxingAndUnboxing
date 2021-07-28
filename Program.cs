using System;
using System.Diagnostics;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timeBoxing = new Stopwatch();
            Stopwatch timeUnboxing = new Stopwatch();
            int RandomNumber = 10;

            timeBoxing.Start();
            object box = RandomNumber;
            timeBoxing.Stop();
            Console.WriteLine(timeBoxing.ElapsedMilliseconds); // Время выполнения упаковки - 9623 мс

            timeUnboxing.Start();
            RandomNumber = (int)box;
            timeUnboxing.Stop();
            Console.WriteLine(timeUnboxing.ElapsedMilliseconds); // Время выполнения распаковки - 6082 мс

            Console.ReadKey();

        }
    }
}
