// Поиск в массиве. Пузырьковая сортировка

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
            Console.WriteLine("Пузырьковая сортировка\n------------------------");
            int arrMax = (int)GetValueUInt("Введите размер массива: ");
            int[] arr = IntRndArray(arrMax, 1, 100);
            int[] arrBase = arr;
            Console.Write($"Сгенерирован массив. "); ArrPrint<int>(arr, 5);
            int passNumber = ArrSortingBubbleBase(ref arrBase);
            Console.Write($"\nОтсортированный массив. Базовая сортировка. "); ArrPrint<int>(arr, 5, 5, false);
            Console.WriteLine($"Число проходов: {passNumber}. ");
            passNumber = ArrSortingBubbleRightShift(ref arrBase);
            Console.Write($"\nОтсортированный массив. Сортировка со сдвигом правого края. "); ArrPrint<int>(arr, 5, 5, false);
            Console.WriteLine($"Число проходов: {passNumber}");
            Console.ReadLine();
        }
        static int ArrSortingBubbleBase(ref int[] arr)
        {
            int counter = 0;
            int N = arr.Length;
            for (int i = 0; i < N; i++)
            {
                counter++;
                for (int j = 0; j < N - 1; j++)
                {
                    counter++;
                    if (arr[j] > arr[j + 1]) Swap(j, j + 1, ref arr, swapPrint);
                }
            }
            return counter;
        }
        static int ArrSortingBubbleRightShift(ref int[] arr)
        {
            int counter = 0;
            int N = arr.Length;
            while (N > 1)
            {
                counter++; int j = 0;
                while (j < N - 1)
                {
                    counter++;
                    if (arr[j] > arr[j + 1]) Swap(j, j + 1, ref arr, swapPrint);
                    j++;
                }
                N--;
            }
            return counter;
        }
        static void Swap(int a, int b, ref int[] arr, bool print = false)
        {
            int c = arr[a];
            arr[a] = arr[b];
            arr[b] = c;
            if (print) PrintSwap(a, b, ref arr);
        }
        static void PrintSwap(int a, int b, ref int[] arr)
        {
            ArrPrint<int>(arr, 15, 5, false);
            Console.CursorTop -= 1;
            Console.CursorLeft = 7 * arr.Length - (arr.Length - 2);
            string mes = string.Empty;
            if (a < b) mes = "Прямой проход";
            else mes = "Обратный проход";
            Console.Write($"{a + 1}<>{b + 1}, (строка выше) {mes}");
        }
    }
}