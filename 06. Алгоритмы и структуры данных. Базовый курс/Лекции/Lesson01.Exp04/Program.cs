// Определение простоты числа

using System;

using static mlConsole.GetData;

namespace Lesson01.Exp04
{
    class Program
    {
        static void Main()
        {
            int number = GetValueInt("Введите число: ");
            int d = 0, i = 2;

            while (i < number)
            {
                if (number % i == 0) d++;
                i++;
            }

            if (d == 0) Console.WriteLine("Число простое");
            else Console.WriteLine("Число не простое");
            Console.ReadLine();
        }
    }
}