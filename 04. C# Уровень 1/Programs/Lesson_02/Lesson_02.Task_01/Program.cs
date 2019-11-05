using System;

// полная форма условного оператора

namespace Lesson_02.Exp_01
{
    class Program
    {
        static void Main()
        {
            int a, b, max;
            Console.WriteLine("Введите два целых числа.");
            Console.Write("Первое число:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число:");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            };
            Console.WriteLine("Наибольшее число {0}", max);
            Console.WriteLine("Для выхода из приложение нажмите Enter");
            Console.ReadLine();
        }
    }
}
