// Определение НОД методом вычитания (алгоритм Евклида)

using System;

using static mlConsole.GetData;

namespace Lesson01.Exp02
{
    class Program
    {
        static void Main()
        {
            int a = GetValueInt("Введите значение а: ");
            int b = GetValueInt("Введите значение b: ");

            while (a != b)
            {
                if (a > b) { a -= b; }
                else { b -= a; }
            }

            Console.WriteLine($"НОД равен: {a}");
            Console.ReadLine();
        }
    }
}