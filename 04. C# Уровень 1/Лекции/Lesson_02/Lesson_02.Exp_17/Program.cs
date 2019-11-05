using System;

// Вывести в диапазоне от 10 до 100 все числа, сумма двух последних цифр которых равна 10

namespace Lesson_02.Exp_17
{
    class Program
    {
        static bool Check(int a)
        {
            if ((a % 10 + a / 10 % 10 == 10)) return true; else return false;
        }

        static void Main()
        {
            for (int i = 10; i <= 1000; i++)
                if (Check(i)) Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
