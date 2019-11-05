using System;

// Разработать метод проверки чётности числа. Метод возвращает true, если число чётное, и false, если число нечётное

namespace Lesson_01.Exp_04
{
    class Program
    {
        static bool Odd(int n)
        {
            return n % 2 == 0;
        }
        static void Main(string[] args)
        {
            int value = 100500;
            Console.WriteLine(Odd(value));
        }

    }
}
