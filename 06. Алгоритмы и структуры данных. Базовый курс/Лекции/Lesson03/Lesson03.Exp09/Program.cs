// Заполнение массива

using System;

using static mlConsole.PrintData;

namespace Lesson03.Exp08
{
    class Program
    {
        static int colDim = 10, rowDim = 10;
        static int colInc = 3, rowInc = 2;

        static void Main()
        {
            DateTime tv1, tv2;
            int[,] arrRowFilling = new int[rowDim, colDim], arrColFilling = new int[rowDim, colDim];

            tv1 = DateTime.Now;
            Console.WriteLine("Заполнение столбцами");
            arrColFill(ref arrColFilling);
            TwoDimArrayPrint(arrColFilling, 5);
            tv2 = DateTime.Now;
            TimeSpan colTime = WorkingTime(tv1, tv2);

            tv1 = DateTime.Now;
            Console.WriteLine("\nЗаполнение строками");
            arrRowlFill(ref arrRowFilling);
            TwoDimArrayPrint(arrColFilling, 5);
            tv2 = DateTime.Now;
            TimeSpan rowlTime = WorkingTime(tv1, tv2);

            Console.WriteLine($"Заполнение СТРОКАМИ в {colTime.TotalMilliseconds / rowlTime.TotalMilliseconds:F2} раз быстрее");
            Console.ReadLine();
        }
        static TimeSpan WorkingTime(DateTime tv1, DateTime tv2)
        {
            TimeSpan tv = tv2 - tv1;
            Console.WriteLine($"Время выполнения: {tv.ToString()}");
            return tv;
        }
        static void arrColFill(ref int[,] arr)
        {
            if (arr.Rank != 2) return;
            int col = arr.GetLength(0), row = arr.GetLength(1);
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    arr[i, j] = i * colInc + j * rowInc;
                }
            }
        }
        static void arrRowlFill(ref int[,] arr)
        {
            int col = arr.GetLength(0), row = arr.GetLength(1);
            for (int j = 0; j < row; j++)
            {
                for (int i = 0; i < col; i++)
                {
                    arr[i, j] = i * colInc + j * rowInc;
                }
            }
        }
    }
}