// Количество маршрутов

using System;

using static mlConsole.PrintData;

namespace Lesson04.Exp01
{
    class Program
    {
        static void Main()
        {
            int colDim = 8, rowDim = 8;
            int[,] arr = new int[rowDim, colDim];
            for (int j = 0; j < arr.GetLength(1); j++) arr[0, j] = 1; // Заполняем единицами верхнюю строку
            for (int i = 1; i < arr.GetLength(0); i++)
            {
                arr[i, 0] = 1; // Заполняем первый столбец единицами
                for (int j = 1; j < arr.GetLength(1); j++) arr[i, j] = arr[i, j - 1] + arr[i - 1, j];
            }
            TwoDimArrayPrint(arr, 8);
            Console.ReadLine();
        }
    }
}