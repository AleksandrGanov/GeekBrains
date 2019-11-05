using System;

// Задача 2. Вычислить частное q и остаток r при делении а на d, не используя операций деления (/) и взятия остатка от деления (%)

namespace Lesson_03.Exp_12
{
    class Program
    {
        static void Main()
        {
            int a = 1000;
            int d = 3;
            // a/d
            int r = a, q = 0;
            while (r >= d)
            {
                r -= d;
                q++;
            }
            Console.WriteLine("Частное {0}, Остаток {1}", q, r);
            Console.ReadLine();
        }
    }
}
