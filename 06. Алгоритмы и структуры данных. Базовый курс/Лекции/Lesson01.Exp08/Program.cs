// Перевод числа из одной системы счисления в другую

using System;

using static mlConsole.GetData;
using static mlConsole.PrintData;

namespace Lesson01.Exp08
{
    class Program
    {
        static int[] bin = { 0 };

        static void Main()
        {
            do
            {
                int N = GetValueInt("Введите значение: ");
                ConvertToBin(N);
                ArrPrint(bin, 15);
            } while (AnsYesNo("Продолжить?"));
        }
        static void ConvertToBin(int n)
        {
            int i = 0;
            while (n > 0)
            {
                Array.Resize(ref bin, ++i);
                bin[i - 1] = n % 2;
                n /= 2;
            }
        }
    }
}