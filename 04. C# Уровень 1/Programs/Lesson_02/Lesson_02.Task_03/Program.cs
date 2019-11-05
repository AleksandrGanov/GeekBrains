using System;

//тернарный оператор

namespace Lesson_02.Exp_03
{
    class Program
    {
        static void Main()
        {
            int x;
            Console.WriteLine("Введите целое число.");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + " - " + ((x % 2 == 0) ? "четное число" : "нечетное число"));
            Console.WriteLine("Для выхода из приложение нажмите Enter");
            Console.ReadLine();
        }
    }
}
