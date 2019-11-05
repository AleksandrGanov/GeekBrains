 using System;

/* Описание задания:
Ганов Александр Анатольевич
====================
a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
 */

namespace Lesson_02.HW_Task_07
{
    class Program
    {
        static void Main()
        {
            int a = 1;
            int b = 500;
            RecursionPrintNumbers(a, b);
            Console.WriteLine($"\nСумма чисел от a до b равна: {RecursionSumNumbers(a, b)}");
            Console.ReadLine();
        }

        static void RecursionPrintNumbers(int a, int b)
        {
            int init = a;
            if (a == init) Console.WriteLine(a);
            if (++a <= b) RecursionPrintNumbers(a, b);
        }
        static int RecursionSumNumbers(int a, int b)
        {
            if (a<b) return a + RecursionSumNumbers(++a, b);
            else return a;
        }
    }
}
