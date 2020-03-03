// Сортировка массива. Шейкерная сортировка

using System;

using static mlArray.ArrMaker;
using static mlConsole.GetData;
using static mlConsole.PrintData;

namespace Lesson03.Exp06
{
    class Program
    {
        static readonly bool swapPrint = true; // Печатать или нет результаты обменов
        static int difCounter = 0; // Счетчик кол-ва операций (сложности)

        static void Main()
        {
            Console.WriteLine("Шейкерная сортировка\n------------------------");
            int arrMax = (int)GetValueUInt("Введите размер массива: ");
            int[] arr = IntRndArray(arrMax, 1, 100);
            Console.Write($"Сгенерирован массив. "); ArrPrint<int>(arr, 15);
            Console.Write($"---------------------------");
            ArrSortingShaker(ref arr);
            Console.WriteLine($"\n---------------------------");
            Console.Write($"Отсортированный массив. "); ArrPrint<int>(arr, 15);
            Console.WriteLine($"Сложность: {difCounter}");
            Console.ReadLine();
        }
        static void ArrSortingShaker(ref int[] arr)
        {
            int N = arr.Length; difCounter = 0;
            int minIndex = 0, maxIndex = arr.Length - 1;
            while (minIndex < maxIndex)
            {
                difCounter++;

                int i = minIndex;
                while (i < maxIndex)
                {
                    difCounter++;
                    if (arr[i] > arr[i + 1]) Swap(i, i + 1, ref arr, swapPrint);
                    i++;
                }
                maxIndex--; N--;

                int j = maxIndex;
                while (j > minIndex)
                {
                    difCounter++;
                    if (arr[j] < arr[j - 1]) Swap(j, j - 1, ref arr, swapPrint);
                    j--;
                }
                minIndex++; N--;
            }
        }
        static void Swap(int a, int b, ref int[] arr, bool print = false)
        {
            difCounter++;
            int c = arr[a];
            arr[a] = arr[b];
            arr[b] = c;
            if (print) PrintSwap(a, b, arr);
        }
    }
}