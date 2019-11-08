using System;

// Пример 2. Возведение каждого элемента массива в квадрат

namespace Lesson_04.Exp_03
{
    class Program
    {
        static void Main()
        {
            int[] a = new int[10];
            int i;
            for (i = 0; i < 10; i++) a[i] = (int)Math.Pow(i, 2);
            for (i = 0; i < 10; i++) Console.WriteLine(a[i]);
            Console.WriteLine();
        }
    }
}
