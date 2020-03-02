// Поиск в массиве. Шейкерная сортировка

using System;

using static mlArray.ArrMaker;
using static mlConsole.GetData;
using static mlConsole.PrintData;

namespace Lesson03.Exp04
{
    class Program
    {
        static readonly bool swapPrint = true; // Печать или нет результаты обменов

        static void Main()
        {
            Console.WriteLine("Шейкерная сортировка\n------------------------");
            int arrMax = (int)GetValueUInt("Введите размер массива: ");
            int[] arr = IntRndArray(arrMax, 1, 100);
            Console.Write($"Сгенерирован массив. "); ArrPrint<int>(arr, 15);
            Console.Write($"---------------------------");
            int passNumber = ArrSortingShaker(ref arr);
            Console.WriteLine($"\n---------------------------");
            Console.Write($"Отсортированный массив. "); ArrPrint<int>(arr, 15);
            Console.WriteLine($"Число проходов: {passNumber}");
            Console.ReadLine();
        }
        static int ArrSortingShaker(ref int[] arr)
        {
            int N = arr.Length;
            int minIndex = 0, maxIndex = arr.Length-1, counter=0;
            while (minIndex<maxIndex)
            {
                counter++;
                
                int i = minIndex;
                while (i < maxIndex)
                {
                    counter++;
                    if (arr[i] > arr[i + 1]) Swap(i, i + 1, ref arr, swapPrint);
                    i++; 
                }
                maxIndex--; N--;

                int j = maxIndex;
                while (j > minIndex)
                {
                    counter++;
                    if (arr[j] < arr[j - 1]) Swap(j, j - 1, ref arr, swapPrint);
                    j--;
                }
                minIndex++; N--;
            }
            return counter;
        }
        static void Swap(int a, int b, ref int[] arr, bool print = false)
        {
            int c = arr[a];
            arr[a] = arr[b];
            arr[b] = c;
            if (print) PrintSwap(a, b, arr);
        }
        static void PrintSwap(int a, int b, int[] arr)
        {
                ArrPrint<int>(arr, 15, 5, false);
                Console.CursorTop -= 1;
                Console.CursorLeft = 7 * arr.Length - (arr.Length - 2);
                string mes = string.Empty;
                if (a < b) mes = "Прямой проход";
                else mes = "Обратный проход";
                Console.Write($"{a + 1}<>{b + 1} (строка выше) {mes}");
        }
    }
}