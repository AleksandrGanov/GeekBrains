// Генератор псеводослучайных чисел

using System;

using static mlConsole.GetData;

namespace Lesson01.Exp10
{
    class Program
    {
        static void Main()
        {
            int x = 1, a = 2, b = 3, m = 100;
            int modulus = GetValueInt("Введите кол-во чисел для генерации: ");

            for (int i = 0; i < modulus; i++)
            {
                x = (a * x + b) % m;
                Console.Write($"{x:F0} ");
            }
            Console.ReadLine();
        }
    }
}