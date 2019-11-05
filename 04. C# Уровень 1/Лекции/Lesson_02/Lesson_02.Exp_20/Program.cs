using System;

/*
 Решим задачу нахождения простых чисел в диапазоне от 1 до 1000000. Напишем метод проверки, является ли число простым, и используем его 
 для подсчёта количества чисел.  В начале цикла сохраним текущее время, по выходу из цикла вычтем текущее время из сохранённого и выведем результат на экран
 */

namespace Lesson_02.Exp_20
{
    class Program
    {
        static bool IsSimple(int n)
        {
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0) return false;
            return true;
        }

        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            int k = 0;
            for (int i = 2; i < 1000000; i++)
                if (IsSimple(i))
                {
                    k++;
                    Console.WriteLine("{0} {1}", k, i);
                }
            Console.WriteLine(k);
            Console.WriteLine(DateTime.Now - start);
        }
    }
}
