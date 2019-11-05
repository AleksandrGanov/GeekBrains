using System;
using System.Threading;

// Структуры для работы со временем

namespace Lesson_03.Exp_05
{
    class Program
    {
        static void Main()
        {
            DateTime start = DateTime.Now;
            Console.WriteLine(start);
            Thread.Sleep(2000);
            DateTime finish = DateTime.Now;
            Console.WriteLine(finish);
            TimeSpan duration = finish - start;
            Console.WriteLine(duration.TotalSeconds);
            Console.ReadLine();
        }
    }
}
