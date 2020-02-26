// Нахождение суммы цифр целого числа

using System;

using static mlConsole.GetData;

namespace Lesson01.Exp06
{
    class Program
    {
        static void Main()
        {
            int n = GetValueInt("Введите число: ");
            Console.WriteLine($"Сумма цифр числа: {SumDigit(n)}");
            Console.ReadLine();
        }
        static int SumDigit(int a)
        {
            int result = 0;
            while (a > 0)
            {
                result += a % 10;
                a /= 10;
            }
            return result;
        }
    }
}