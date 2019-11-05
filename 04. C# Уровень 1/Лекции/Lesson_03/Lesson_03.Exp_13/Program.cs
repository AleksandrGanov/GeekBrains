using System;

// Задача 3. Написать программу табуляции произвольной функции в диапазоне от a до b (решение без использования ООП)

namespace Lesson_03.Exp_13
{
    class Program
    {
        static double F(double x)
        {
            return 1 / x;
        }

        static void Main()
        {
            double a = -5, b = 5, h = 0.5;
            Console.WriteLine("{0,10}{1,10}", "x", "F(x)");
            for (double x = a; x <= b; x += h)
            {
                Console.WriteLine("{0,10}{1,10:f3}", x, F(x));
            }
            Console.ReadLine();
        }
    }
}
