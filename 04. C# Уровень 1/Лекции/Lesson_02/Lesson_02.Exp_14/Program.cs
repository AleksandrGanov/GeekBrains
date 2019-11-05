using System;

// Структуры для работы со временем

namespace Lesson_02.Exp_14
{
    class Program
    {
        static void Main()
        {
            DateTime start = DateTime.Now;
            System.Threading.Thread.Sleep(20);// делаем паузу

            // текст программы

            DateTime finish = DateTime.Now;
            Console.WriteLine(finish - start);
        }
    }
}
