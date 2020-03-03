// Поиск в массиве. Поиск методом половинного деления

using System;

using static mlArray.ArrMaker;
using static mlConsole.GetData;
using static mlConsole.PrintData;

namespace Lesson03.Exp03
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Binary Search\n------------------------");
            int arrMax = (int)GetValueUInt("Введите размер массива: ");
            int[] arr = IntRndArraySorted(arrMax, 1, 100);
            Console.Write($"Сгенерирован массив. "); ArrPrint<int>(arr, 5);
            int searchVal = (int)GetValueUInt("Введите искомое значение: ");
            FindValueBinary(arr, searchVal);
            Console.ReadLine();
        }
        static int FindValueBinary(int[] arr, int searchValue)
        {
            int L = 0, R = arr.Length - 1, m = L+(R - L) / 2;
            while (L < R && arr[m] != searchValue)
            {
                if (arr[m] < searchValue) L = m + 1;
                else R = m - 1;
                m = L+(R - L) / 2;
            }
            if (arr[m]==searchValue) 
            {
                Console.WriteLine($"Значение {searchValue} найдено, позиция {m + 1} массива");
                return m;
            }
            else
            {
                Console.WriteLine("Искомое значение не найдено");
                return -1;
            }
        }
    }
}