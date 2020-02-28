// Рекурсия, пример №2. Найти сумму цифр числа A

using System;

namespace Lesson02.Exp07
{
    class Program
    {
        static void Main()
        {
            int number = 125;
            Console.WriteLine($"Сумма цифр числа {number}: {FindSumCycle(125).ToString()}, метод \"Цикл\"");
            Console.WriteLine($"Сумма цифр числа {number}: {FindSumRecursion(125).ToString()}, метод \"Рекурсия\"");
            Console.ReadLine();
        }
        static int FindSumCycle(int a)
        {
            int sum = 0;
            while (a > 0)
            {
                sum += a % 10;
                a /= 10;
            }
            return sum;
        }
        static int FindSumRecursion(int a)
        {
            if (a == 0) return 0;
            else return FindSumRecursion(a/10)+a%10;
        }
    }
}