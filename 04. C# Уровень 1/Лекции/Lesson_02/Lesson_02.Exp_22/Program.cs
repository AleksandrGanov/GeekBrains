using System;

// рекурсия #4. последовательность Фибоначчи

namespace Lesson_02.Exp_22
{
    class Program
    {

        static uint Fib(uint n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            uint n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(Fib(n));
            Console.ReadLine();
        }
    }
}
