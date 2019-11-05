using System;

// Реализовать метод нахождения NOD, используя алгоритм Евклида

namespace Lesson_02.Exp_16
{
    class Program
    {
        static int NOD(int a, int b)
        {
            while (a != b)
                if (a > b) a -= b; else b -= a;
            return a;
        }

        static void Main()
        {
            int a = 3;
            int b = 7;
            Console.WriteLine(NOD(a, b));
            Console.ReadLine();
        }
    }
}
