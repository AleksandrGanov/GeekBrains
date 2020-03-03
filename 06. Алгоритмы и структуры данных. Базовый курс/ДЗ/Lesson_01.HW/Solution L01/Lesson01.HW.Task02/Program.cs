/* Описание задания:
Ганов Александр Анатольевич
====================
Найти максимальное из четырех чисел. Массивы не использовать
*/

using System;

using static mlConsole.GetData;

namespace Lesson01.HW.Task02
{
    class Program
    {
        static void Main()
        {
            int dig1 = GetValueInt("Введите число #1: ");
            int dig2 = GetValueInt("Введите число #2: ");
            int dig3 = GetValueInt("Введите число #3: ");
            int dig4 = GetValueInt("Введите число #4: ");

            Console.WriteLine($"Максимальное число: {MaxDigit(MaxDigit(MaxDigit(dig1, dig2), dig3), dig4)}");
            Console.ReadLine();
        }
        static int MaxDigit(int dig1, int dig2)
        {
            if (dig1 > dig2) return dig1;
            else return dig2;
        }
    }
}