using System;

/* Описание задания:
Ганов Александр Анатольевич
====================
*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
    «Хорошим» называется число, которое делится на сумму своих цифр.
Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
 */

namespace Lesson_02.HW_Task_06
{
    class Program
    {
        static void Main()
        {
            const int min = 1;
            const int max = 1000000;
            DateTime startTime = DateTime.Now;

            for (int i = min; i <= max; i++)
            {
                if (IfGoodNumber(i)) Console.WriteLine(i);
            }

            Console.WriteLine($"Время поиска: {(DateTime.Now - startTime).TotalSeconds:F3} сек");
            Console.ReadLine();
        }

        static bool IfGoodNumber(int num)
        {
            int tempNum = num;
            int sum = 0;

            while (tempNum > 0)
            {
                sum += tempNum % 10;
                tempNum /= 10;
            }
            return num % sum == 0;
        }
    }
}
