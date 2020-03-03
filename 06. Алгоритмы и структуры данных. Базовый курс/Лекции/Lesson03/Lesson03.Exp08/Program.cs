// Сортировка массива. Сортировка вставками

using System;

using static mlArray.ArrMaker;
using static mlConsole.GetData;
using static mlConsole.PrintData;

namespace Lesson03.Exp08
{
    class Program
    {
        static readonly bool swapPrint = true; // Печатать или нет результаты обменов
        static int difCounter = 0; // Счетчик кол-ва операций (сложности)

        static void Main()
        {
            Console.WriteLine("Сортировка методом вставки\n------------------------");
            int arrMax = (int)GetValueUInt("Введите размер массива: ");
            int[] arr = IntRndArray(arrMax, 1, 100);
            Console.Write($"Сгенерирован массив. "); ArrPrint<int>(arr, 15);
            Console.Write($"---------------------------");
            int passNumber = ArrSortingInsertion(ref arr);
            Console.WriteLine($"\n---------------------------");
            Console.Write($"Отсортированный массив. "); ArrPrint<int>(arr, 15);
            Console.WriteLine($"Число операций: {passNumber}");
            Console.ReadLine();
        }
        static int ArrSortingInsertion(ref int[] arr)
        {
            int N = arr.Length; difCounter = 0;
            for (int i = 0; i < N; i++)
            {
                difCounter++;
                int minVal = arr[i]; int j = i;
                while (j > 0 && arr[j - 1] > minVal)
                {
                    difCounter++;
                    Swap(j-1, j, ref arr, swapPrint);
                    j--;
                }
            }
            return difCounter;
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