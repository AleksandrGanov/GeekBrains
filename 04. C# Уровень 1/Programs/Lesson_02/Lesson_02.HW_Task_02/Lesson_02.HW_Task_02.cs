using System;

/* Описание задания:
Ганов Александр Анатольевич
====================
Написать метод подсчета количества цифр числа
 */

namespace Lesson_02.HW_Task_02
{
    class Program
    {
        static void Main()
        {
            GetsDigitsNumber(125445545454);
        }

        static void GetsDigitsNumber(long number)
        {
            Console.WriteLine($"Количество цифр в числе: {number.ToString().Length}");
            Console.ReadLine();
        }
    }
}
