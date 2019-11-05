using System;

// рекурсия #1. Пример вывода чисел от a до b с использованием рекурсивного алгоритма

namespace Lesson_02.Exp_12
{
    class Program
    {
        static void Main()
        {
            Loop(3, 13);
            Console.ReadLine();
        }

        static void Loop(int a, int b)
        {
            Console.Write("{0,2:F2} ", a);
            if (a < b) Loop(a + 1, b);
        }
    }
}
