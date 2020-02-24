// Определение НОД методом вычитания (ускоренный алгоритм Евклида)

using System;

using static mlConsole.GetData;

namespace Lesson01.Exp03
{
    class Program
    {
        static void Main()
        {
            int a = GetValueInt("Введите значение а: ");
            int b = GetValueInt("Введите значение b: ");
            int c;

            while (b>0)
            {
                c = a % b;
                a = b;
                b = c;
            }

            Console.WriteLine($"НОД равен: {a}");
            Console.ReadLine();
        }
    }
}