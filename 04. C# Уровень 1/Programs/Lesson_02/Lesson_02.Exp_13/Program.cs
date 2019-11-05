using System;

// рекурсия #2. Найти сумму цифр числа A

namespace Lesson_02.Exp_13
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(RecursiveSum(1303));
        }

        static long RecursiveSum(long a) // рекурсивный метод
        {
            if (a == 0) return 0; // если a =0, возвращаем 0
            else return RecursiveSum(a / 10) + a % 10; // иначе вызываем рекурсивно сами себя
        }
    }
}
