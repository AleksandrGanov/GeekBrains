/* Описание задания:
Ганов Александр Анатольевич
====================
Реализовать функцию возведения числа a в степень b:
a. Без рекурсии.
b. Рекурсивно.
c. *Рекурсивно, используя свойство чётности степени
*/

using System;

using static mlConsole.GetData;

namespace Lesson02.HW.Task02
{
    class Program
    {
        static void Main()
        {
            int dig = (int)GetValueUInt("Введите число для возведения в степень: ");
            int pow = (int)GetValueUInt("Введите степень: ");
            Console.WriteLine($"Возведение в степень: {dig}^{pow}");
            PowerDifWays(dig, pow);
            Console.ReadLine();
        }
        private static void PowerDifWays(int dig, int pow)
        {
            Console.WriteLine($"Встроенный ({Math.Pow(dig, pow)}), Цикл ({PowerCycle(dig, pow)}), Рекурсия ({PowerRecursion(dig, pow)})");
        }
        static int PowerCycle(int dig, int pow)
        {
            if (pow == 0) return 1;
            int res = 1;
            while (pow > 0)
            {
                res *= dig;
                pow--;
            }
            return res;
        }
        static int PowerRecursion(int dig, int pow)
        {
            if (pow == 0) return 1;
            return dig * PowerRecursion(dig, pow - 1);
        }
    }
}