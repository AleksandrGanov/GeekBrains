// Задача ЕГЭ. Калькулятор
/*
У исполнителя Калькулятор две команды, которым присвоены номера: 1. Прибавь 1, 2. Умножь на 2
Сколько есть программ, которые число 1 преобразуют в число 16?
 */

using System;

namespace Lesson04.Exp03
{
    class Program
    {
        static void Main()
        {
            int n = 16; // Число, которое нужно получить в результате
            Console.WriteLine(VarNumber(n));
            Console.ReadLine();
        }
        static int VarNumber(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            if (n % 2 == 0) return VarNumber(n - 1) + VarNumber(n / 2);
            else return VarNumber(n - 1);
        }
    }
}