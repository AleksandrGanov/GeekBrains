using System;

// Написать функцию обмена значениями двух переменных

namespace Lesson_03.Exp_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("a={0} b={1}", a, b);
            Swap(ref a, ref b);// Пример вызова
            Console.WriteLine("a={0} b={1}", a, b);
            Console.ReadLine();
        }

        static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
    }
}
