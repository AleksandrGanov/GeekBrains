// Функция возведения в степень a^b
// Функция ускоренного возведения в степень

using System;

using static mlConsole.GetData;

namespace Lesson01.Exp08
{
    class Program
    {
        static void Main()
        {
            do
            {
            int digit = GetValueInt("Введите число для возведения в степень: ");
            uint power = GetValueUInt("Введите степень: ");

            Console.WriteLine($"PowerCommon: {PowerCommon(digit, power)}");
            Console.WriteLine($"PowerQuick: {PowerQuick(digit, power)}");
            } while (AnsYesNo("Продолжить?"));
        }
        static int PowerCommon(int digit, uint power)
        {
            int ans = 1;
            for (int i = 0; i < power; i++)
            {
                ans *= digit;
            }
            return ans;
        }
        static int PowerQuick(int digit, uint power)
        {
            int n = 1;
            while (power >= 1)
            {
                if (power % 2 != 0)
                {
                    power--;
                    n *= digit;
                }
                else
                {
                    digit *= digit;
                    power /= 2;
                }
            }
            return n;
        }
    }
}