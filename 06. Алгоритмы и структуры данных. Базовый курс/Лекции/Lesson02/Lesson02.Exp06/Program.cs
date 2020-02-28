// Рекурсия, пример №1. Цикл с помощью рекурсии

using System;

namespace Lesson02.Exp06
{
    class Program
    {
        static void Main()
        {
            Loop(0, 10);
            Console.ReadLine();
        }
        static void Loop(int a, int b)
        {
            Console.Write($"{a} ");
            if (a < b) Loop(a + 1, b);
        }
    }
}