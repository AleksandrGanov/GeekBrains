/* Описание задания:
Ганов Александр Анатольевич
====================
Попробовать оптимизировать пузырьковую сортировку. Сравнить количество операций сравнения
оптимизированной и не оптимизированной программы. Написать функции сортировки, которые
возвращают количество операций
 */

using System;

using static mlArray.ArrMaker;
using static mlConsole.GetData;
using static mlConsole.PrintData;

namespace Lesson03.HW.Task01
{
    class Program
    {
        static readonly bool swapPrint = true; // Печатать или нет результаты обменов
        static int difCounter = 0; // Счетчик кол-ва операций (сложности)

        static void Main()
        {
            Console.WriteLine("Пузырьковая сортировка\n------------------------");
            int arrMax = (int)GetValueUInt("Введите размер массива: ");
            int[] arr = IntRndArray(arrMax, 1, 100);
            int[] arr01 = new int[arr.Length], arr02 = new int[arr.Length];
            Array.Copy(arr, arr01, arr.Length); Array.Copy(arr, arr02, arr.Length);
            Console.Write($"Сгенерирован массив. "); ArrPrint<int>(arr, 10);

            ArrSortingBubbleBase(ref arr01);
            Console.Write($"\nОтсортированный массив. Базовая сортировка. "); ArrPrint<int>(arr01, 10, 5, false);
            Console.WriteLine($"Сложность: {difCounter}");

            ArrSortingBubbleRightShift(ref arr02);
            Console.Write($"\nОтсортированный массив. Сортировка со сдвигом правого края. "); ArrPrint<int>(arr02, 10, 5, false);
            Console.WriteLine($"Сложность: {difCounter}");
            Console.ReadLine();
        }
        static void ArrSortingBubbleBase(ref int[] arr)
        {
            difCounter = 0;
            int N = arr.Length;
            for (int i = 0; i < N; i++)
            {
                difCounter++;
                for (int j = 0; j < N - 1; j++)
                {
                    difCounter++;
                    if (arr[j] > arr[j + 1]) Swap(j, j + 1, ref arr, swapPrint);
                }
            }
        }
        static void ArrSortingBubbleRightShift(ref int[] arr)
        {
            difCounter = 0;
            int N = arr.Length;
            while (N > 1)
            {
                difCounter++; int j = 0;
                while (j < N - 1)
                {
                    difCounter++;
                    if (arr[j] > arr[j + 1]) Swap(j, j + 1, ref arr, swapPrint);
                    j++;
                }
                N--;
            }
        }
        static void Swap(int a, int b, ref int[] arr, bool print = false)
        {
            difCounter++;
            int c = arr[a];
            arr[a] = arr[b];
            arr[b] = c;
            if (print) PrintSwap(a, b, ref arr);
        }
    }
}