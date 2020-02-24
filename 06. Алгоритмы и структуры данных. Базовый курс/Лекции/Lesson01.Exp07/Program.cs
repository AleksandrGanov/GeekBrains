// Переворот числа

using System;

using static mlConsole.GetData;

namespace Lesson01.Exp07
{
    class Program
    {
        static void Main()
        {
            int n = GetValueInt("Введите число: ");
            Console.WriteLine($"Перевернутое число: {DigitReverse(n)}");
            Console.ReadLine();
        }
        static int DigitReverse(int a)
        {
            int result = 0;
            while (a > 0)
            {
                result = result * 10 + a % 10;
                a /= 10;
            }
            return result;
        }
    }
}