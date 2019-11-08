using System;

// Пример 1. Вывод массива

namespace Lesson_04.Exp_02
{
    class Program
    {
        static void Main()
        {
            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int i;
            for (i = 0; i < 10; i++)
                Console.Write("{0,2}", a[i]);
            Console.ReadLine();
        }
    }
}
