using System;

// Задача. Написать метод, внутри которого поменять знаки нескольким переменным

namespace Lesson_03.Exp_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3;
            Console.WriteLine($"До смены знака: {a}, {b}, {c}");
            ChangeSign(ref a, ref b, ref c);
            Console.WriteLine($"После смены знака: {a}, {b}, {c}");
            Console.ReadLine();
        }

        static void ChangeSign(ref int a, ref int b, ref int c)
        {
            a = -a;
            b = -b;
            c = -c;
        }
    }
}
