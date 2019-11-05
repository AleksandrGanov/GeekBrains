using System;

// Пример генерации последовательности из 10 случайных чисел в диапазоне от 0 до 10

namespace Lesson_03.Exp_09
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++) Console.Write("[{0,2:0#}]", rnd.Next(0, 10));
            Console.ReadLine();
        }
    }
}
