// Сортировка массива. Сортировка методом выбора

using System;

using static mlArray.ArrMaker;
using static mlConsole.GetData;
using static mlConsole.PrintData;

namespace Lesson03.Exp07
{
    class Program
    {
        static readonly bool swapPrint = true; // Печатать или нет результаты обменов
        static int difCounter = 0; // Счетчик кол-ва операций (сложности)

        static void Main()
        {
            Console.WriteLine("Сортировка методом выбора\n------------------------");
            int arrMax = (int)GetValueUInt("Введите размер массива: ");
            int[] arr = IntRndArray(arrMax, 1, 100);
            Console.Write($"Сгенерирован массив. "); ArrPrint<int>(arr, 15);
            Console.Write($"---------------------------");
            ArrSortingSelection(ref arr);
            Console.WriteLine($"\n---------------------------");
            Console.Write($"Отсортированный массив. "); ArrPrint<int>(arr, 15);
            Console.WriteLine($"Число операций: {difCounter}");
            Console.ReadLine();
        }
        static void ArrSortingSelection(ref int[] arr)
        {
            int N = arr.Length; difCounter = 0;
            for (int i = 0; i < N; i++)
            {
                difCounter++;
                int jmin = i;
                for (int j = i + 1; j < N; j++)
                {
                    difCounter++;
                    if (arr[jmin] > arr[j]) jmin = j;
                }
                Swap(i, jmin, ref arr, swapPrint);
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