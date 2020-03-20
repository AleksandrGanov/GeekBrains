/* Описание задания:
Ганов Александр Анатольевич
====================
Написать рекурсивную функцию обхода графа в глубину
*/

/* Логика работы:
 начинаем обход с какой-либо вершины, пишем в очередь все вершины, в которые можно прийти с текущей вершины,
 дополнительно запоминаем в отдельную перменную на сколько вершин можно пройти из текущей. Это нужно для 
 принятия решения о вызове рекурсии на очередной вершине из очереди, то есть перед тем, как вызвать рекурсию, 
 на вершине, которая есть в очереди программа просматривает переменную, в которой указано какое кол-во вершин
 можно достигнуть с текущией анализируемой вершины из очереди, если на ней нет доступных вершин, то ее дальнешая
 обработка прекращается, рекурсивно вызванный метод оканчивается и идет переход на следующую вершину в очееди,
 где последовательность дествий повторяется
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.IO;

using static Microsoft.SmallBasic.Library.GraphicsWindow;
using static mlConsole.GetData;
using static mlConsole.PrintData;

namespace Lesson07.HW.Task03
{
    class Program
    {
        static void Main()
        {
            GenerateMatrix(10, 1);
            int[,] arr = ReadMatrixFile();
            TwoDimArrayPrint<int>(arr, 3, "Матрица смежности: ");

            int vertexStart;
            do { vertexStart = (int)GetValueUInt($"Введите начальную вершину для обхода от {1} до {arr.GetLength(0)}:"); }
            while (!(vertexStart != 0 && vertexStart < arr.GetLength(0)));
            Console.WriteLine($"Обходим граф начиная с вершины № {vertexStart}");
            WaveInDepth(arr, vertexStart);

            Console.ReadLine();
        }

        /// <summary>
        /// Структура для хранения координат центров узлов графа
        /// </summary>
        public struct Point { public int X; public int Y; }

        /// <summary>
        /// Метод считывает матрицу смежности из файла
        /// </summary>
        /// <returns>Матрицу смежности в виде двумерного массива</returns>
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
            System.IO.File.Delete("Matrix.txt");
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
        /// <summary>
        /// Метод организует проход через граф волны "в глубину"
        /// </summary>
        /// <param name="arr">Матрица смежности, представляющая граф</param>
        /// <param name="vertexStart">Узел, с которого необходимо начинать обход</param>
        private static void WaveInDepth(int[,] arr, int vertexStart = 1)
        {
            vertexStart -= 1; // Приводим значение к нумерации массива с нуля
            int vertexNum = arr.GetLength(0); // Количество вершин (узлов) графа
            int[] visited = new int[vertexNum]; // Массив посещений вершин
            int counter = 1;
            Queue front = new Queue(vertexNum);
            Point[] arrPoint = DrawGraph(arr); // Получаем массив центров отрисованных узлов
            BrushColor = "Red";
            RecursiveSearch(vertexStart);

            void RecursiveSearch(int vertexStartSrch)
            {
                int vertexCounter = 0; // Cчетчик вершин волны определенного цикла
                visited[vertexStartSrch] = 1;
                MarkWaved(vertexStartSrch);
                for (int i = 0; i < vertexNum; i++)
                    if (arr[vertexStartSrch, i] != 0 && visited[i] != 1 && i != vertexNum)
                    {
                        visited[i] = 1;
                        front.Enqueue(i);
                        vertexCounter++;
                    }
                if(vertexCounter>0) while (front.Count != 0) { RecursiveSearch((int)front.Dequeue()); };
            } // Рекурсивный проход фронта волны с использование очереди
            void MarkWaved(int vertexFrontNum)
            {
                const int offset = 20;
                DrawText(arrPoint[vertexFrontNum].X - offset / 2, arrPoint[vertexFrontNum].Y - (vertexFrontNum < vertexNum / 2 ? offset : -offset), $"w:{counter++}");
            } // Отрисовка порядка прохода цифрами на графах
        }
        /// <summary>
        /// Метод делает отрисовку графа и его связей. Подсветка узла желтым обозначает, 
        /// что в узле есть "закольцовка", то есть из узла есть направление обратно в узел
        /// </summary>
        /// <param name="arr">Матрица смежности, представляющая граф</param>
        /// <returns>Координаты центров узлов графа</returns>
        static Point[] DrawGraph(int[,] arr)
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
            return pArrLine;
        }
    }
}