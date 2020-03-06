/* Описание задания:
Ганов Александр Анатольевич
====================
1. *Количество маршрутов с препятствиями. Реализовать чтение массива с препятствием и
нахождение количество маршрутов.
Например, карта:
3 3
1 1 1
0 1 0
0 1 0
 */

using System;

using static mlConsole.PrintData;

namespace Lesson04.HW.Task01
{
    class Program
    {
        static void Main()
        {
            int rowDim = 8, colDim = 8;
            int[,] arr = new int[rowDim, colDim];
            int[,] map = new int[rowDim, colDim];

            for (int i = 0; i < map.GetLength(0); i++) for (int j = 0; j < map.GetLength(1); j++) map[i, j] = 1; // Заполняем map едицами
            map[4, 4] = 0; map[2, 3] = 0; map[1, 7] = 0; // Запретные клетки
            for (int j = 0; j < arr.GetLength(1); j++) arr[0, j] = 1; // Заполняем единицами верхнюю строку
            for (int i = 1; i < arr.GetLength(0); i++)
            {
                arr[i, 0] = 1; // Заполняем первый столбец единицами
                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    if (map[i, j] == 0) arr[i, j] = 0;
                    else arr[i, j] = arr[i, j - 1] + arr[i - 1, j];
                }
            }

            TwoDimArrayPrint(map, 3, "Карта запретов:");
            TwoDimArrayPrint(arr, 7, "Массив решений:");
            Console.ReadLine();
        }
    }
}