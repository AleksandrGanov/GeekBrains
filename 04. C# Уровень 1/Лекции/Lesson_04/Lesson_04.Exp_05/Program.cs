using System;

// Пример объявления двумерного массива (прямоугольный массив)

namespace Lesson_04.Exp_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявление двумерного массива
            int[,] multiDimensionalArray1 = new int[2, 3];
            // Объявление и заполнение двумерного массива
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            foreach (var i in multiDimensionalArray2) Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
