/* Описание задания:
Ганов Александр Анатольевич
====================
Написать функции, которые считывают матрицу смежности из файла и выводят ее на экран
*/
/* Реализованы:
    -- генерация матрицы с записью в файл
    -- чтение матрицы из файла
    -- вывод матрицы в текстовом варианте
    -- простенькая визуализация графа (если узел с желтым контуром, значит в нем есть "закольцовка")
    */

using System;
using System.Diagnostics;
using System.IO;

using static Microsoft.SmallBasic.Library.GraphicsWindow;

using static mlConsole.PrintData;

namespace Lesson07.HW.Task01
{
    class Program
    {
        public struct Point
        {
            public int X;
            public int Y;
        }
        static void Main()
        {
            GenerateMatrix(12, 3);
            int[,] arr = ReadMatrixFile();
            TwoDimArrayPrint<int>(arr, 3, "Матрица смежности: ");
            DrawGraph(arr);
            Console.ReadLine();
        }
        private static int[,] ReadMatrixFile()
        {
            StreamReader sr = new StreamReader(new FileStream("Matrix.txt", FileMode.Open));
            int.TryParse(sr.ReadLine(), out int size);
            int[,] arr = new int[size, size];
            int counter = 1;
            while (counter < size)
            {
                try
                {
                    string str = sr.ReadLine().Trim().Replace(" ", "");
                    for (int i = 0; i < str.Length; i++) arr[counter, i] = int.Parse(char.ToString(str[i]));
                    counter++;
                }
                catch (Exception e) { Console.WriteLine($"Неверная структура файла: {e.Message}"); }
            }
            sr.Close();
            return arr;
        }
        /// <summary>
        /// Метод генерирует матрицу смежности
        /// </summary>
        /// <param name="rndSize">Кол-во узлов (всегда уменьшается до четного кол-ва)</param>
        /// <param name="conNumMax">Кол-во связей каждого узла</param>
        private static void GenerateMatrix(int rndSize, int conNumMax)
        {
            if (conNumMax > rndSize) conNumMax = rndSize;
            rndSize /= 2; rndSize *= 2; // Сделано только для четного кол-ва узлов
            Random rnd = new Random();
            File.Delete("Matrix.txt");
            StreamWriter sw = new StreamWriter(new FileStream("Matrix.txt", FileMode.OpenOrCreate));
            sw.WriteLine(rndSize);
            int[,] arr = new int[rndSize, rndSize];
            int counter, digit;
            for (int i = 0; i < rndSize; i++)
            {
                for (int j = 0; j < rndSize; j++)
                {
                    counter = 0;
                    for (int k = 0; k < i; k++) if (arr[k, j] > 0) counter++;
                    for (int k = 0; k < j; k++) if (arr[i, k] > 0) counter++;
                    if (counter < conNumMax) digit = rnd.Next(0, 9); else digit = 0;
                    sw.Write($"{digit} ");
                    arr[i, j] = digit;
                }
                sw.WriteLine("");
            }
            sw.Close();
        }
        static void DrawGraph(int[,] arr)
        {
            int arrRow = arr.GetLength(0), arrCol = arrRow;
            Point[,] pArr = new Point[2, arrRow / 2];
            int xInit = 80, yInit = xInit, space = xInit / 2, increment = xInit + space;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < arrRow / 2; j++)
                {
                    Debug.Print($"i {i}, j {j}");
                    pArr[i, j] = new Point() { X = xInit, Y = yInit };
                    xInit += increment;
                }
                yInit += increment;
                xInit = pArr[0, 0].X;
            }
            
            // GraphicsWindow
            CanResize = false;
            Title = $"Граф {arrRow} узл.";
            Width = arrRow / 2 * (xInit + space) + space;
            Height = 2 * (xInit + space) + space;
            Point[] pArrLine = new Point[arrRow];
            int counter = 0;
            foreach (var point in pArr)
            {
                pArrLine[counter] = point;
                counter++;
            }
            for (int i = 0; i < arrRow; i++)
            {
                PenColor = "Black";
                DrawEllipse(pArrLine[i].X - xInit / 2, pArrLine[i].Y - xInit / 2, xInit, xInit);
                PenColor = "Red";
                for (int j = 0; j < arrCol; j++)
                {
                    PenColor = "Yellow";
                    if (i == j && arr[i, j] != 0) DrawEllipse(pArrLine[i].X - xInit / 2, pArrLine[i].Y - xInit / 2, xInit, xInit);
                    PenColor = "Red";
                    if (i != j && arr[i, j] != 0) DrawLine(pArrLine[i].X, pArrLine[i].Y, pArrLine[j].X, pArrLine[j].Y);
                    DrawText(pArrLine[i].X, pArrLine[i].Y, i + 1);
                }
            }
            Show();
        }
    }
}