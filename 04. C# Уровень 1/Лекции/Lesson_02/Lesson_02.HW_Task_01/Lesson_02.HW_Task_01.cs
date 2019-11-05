using System;

/* Описание задания:
Ганов Александр Анатольевич
====================
Написать метод, возвращающий минимальное из трёх чисел
 */

namespace Lesson_02.HW_Task_01
{
    class Program
    {
        static void Main()
        {
            int[] arr = new[] { 2, 6, 3 };
            Console.WriteLine($"Минимальное значение: {GetMinNumber(arr)}");
            Console.ReadLine();
        }

        static int GetMinNumber(int[] arr)
        {
            int min = arr[0];
            foreach (int num in arr)
            {
                if (min > num) min = num;
            }
            return min;
        }
    }
}
