using System;

// рекурсия №3. факториал

namespace Lesson_02.Exp_21
{
    class Program
    {

        static uint Factorial(uint n)
        {
            if (n == 0) return 1;
            else return Factorial(n - 1) * n;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            uint n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(Factorial(n));
            Console.ReadLine();
        }
    }
}
