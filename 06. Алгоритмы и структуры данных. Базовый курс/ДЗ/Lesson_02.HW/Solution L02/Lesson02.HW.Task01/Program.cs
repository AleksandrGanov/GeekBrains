/* Описание задания:
Ганов Александр Анатольевич
====================
Реализовать функцию перевода чисел из десятичной системы в двоичную, используя рекурсию
 */

using System;

namespace Lesson02.HW.Task01
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 30; i++) ConvertDifWays(i); 
            Console.ReadLine();
        }
        private static void ConvertDifWays(int number)
        {
            Console.WriteLine($"Конвертация Int-->Bin число: {number}, " +
                $"Рекурсия ({IntToBinRecursion(number).ToString()}), " +
                $"Цикл ({IntToBinCycle(number)}), " +
                $"Встроенный метод С# ({Convert.ToString(number, 2)})");
        }
        static string IntToBinCycle(int num)
        {
            if (num == 0) return "0";
            string res = string.Empty;
            int rem;
            while (num > 0)
            {
                rem = num % 2;
                num /= 2;
                res =rem.ToString()+res;   
            }
            return res;
        }
        static int IntToBinRecursion(int num)
        {
            if (num / 2 == 0) return num % 2;
            else return IntToBinRecursion(num / 2) * 10 + num % 2;
        }
    }
}