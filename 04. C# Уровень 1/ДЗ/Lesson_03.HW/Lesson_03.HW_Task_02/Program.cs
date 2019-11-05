using System;
using System.Collections.Generic;
using UserInteraction;

/* Описание задания:
Ганов Александр Анатольевич
====================
С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
    Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse
 */

namespace Lesson_03.HW_Task_02
{
    class Program
    {
        static void Main()
        {
            double digit;
            double sum = 0;
            List<double> lst = new List<double>();
            ConsoleInteraction ask;

            do
            {
                digit = ask.GetValueDouble("Введите любое число: ");
                if (digit % 2 != 0 && digit > 0)
                {
                    lst.Add(digit);
                    sum += digit;
                }
            } while (digit != 0);
            if (sum > 0)
            {
                Console.WriteLine($"Сумма нечетных положительных чисел: {sum}");
                Console.WriteLine($"Были введены следующие числа: ");
                foreach (double lstItem in lst) Console.WriteLine(lstItem);
            }
            else Console.WriteLine("Вы не ввели ни одно нечетное положительное число");
            Console.ReadLine();
        }
    }
}
