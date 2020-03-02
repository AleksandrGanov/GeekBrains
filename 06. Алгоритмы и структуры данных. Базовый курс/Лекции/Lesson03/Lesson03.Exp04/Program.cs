// Поиск в массиве. Интерполяционный поиск

using System;

using static mlArray.ArrMaker;
using static mlConsole.GetData;
using static mlConsole.PrintData;

namespace Lesson03.Exp04
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Interpolation Search\n------------------------");
            int arrMax = (int)GetValueUInt("Введите размер массива: ");
            int[] arr = IntRndArraySorted(arrMax, 1, 100);
            Console.Write($"Сгенерирован массив. "); ArrPrint<int>(arr, 5);
            int searchVal = (int)GetValueUInt("Введите искомое значение: ");
            FindValueInterpolation(arr, searchVal);
            Console.ReadLine();
        }
        static int FindValueInterpolation(int[] arr, int searchValue)
        {
            int min = 0, max = arr.Length - 1;
            if (searchValue > arr[max])
            {
                Console.WriteLine("Искомое значение не найдено");
                return 0;
            }
            while (min<=max)
            {
                int mid = min + (max - min) * (searchValue - arr[min]) / (arr[max] - arr[min]);
                if (arr[mid] == searchValue)
                {
                    Console.WriteLine($"Значение {searchValue} найдено, позиция {mid + 1} массива");
                    return mid;
                }
                else if (arr[mid] < searchValue) min = mid + 1;
                else if (arr[mid] > searchValue) max = mid - 1;
            }
            Console.WriteLine("Искомое значение не найдено");
            return 0;
        }
    }
}