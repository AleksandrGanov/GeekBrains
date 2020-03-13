/* Описание задания:
Ганов Александр Анатольевич
====================
Реализовать простейшую хеш-функцию. На вход функции подается строка, на выходе сумма кодов символов
 */

using System;

namespace Lesson06.HW.Task01
{
    class Program
    {
        static void Main()
        {
            string str = "Тестовая строка";
            Console.WriteLine($"Hash Function: {SimpleHashFunction(str)}");
            Console.ReadLine();
        }
        static double SimpleHashFunction(string str)
        {
            double sum = 0;
            foreach (char item in str) sum += (int)item;
            return sum;
        }
    }
}