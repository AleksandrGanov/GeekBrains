// Поиск в массиве. Линейный поиск

using System;

using static mlArray.ArrMaker;
using static mlConsole.GetData;
using static mlConsole.PrintData;

namespace Lesson03.Exp01
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Линейный поиск в массиве\n------------------------");
            uint arrMax = GetValueUInt("Введите размер массива: ");
            int[] arr = IntRndArray((int)arrMax, 1, 100);
            Console.Write($"Сгенерирован массив. "); ArrPrint<int>(arr, 5);
            int searchVal = (int)GetValueUInt("Введите искомое значение: ");
            FindValue(arr, searchVal);
            Console.ReadLine();
        }
        static int FindValue(int[] arr, int searchValue)
        {
            int counter = 0, N = arr.Length;
            while (counter < N && arr[counter] != searchValue) counter++;
            if (counter != N)
            {
                Console.WriteLine($"Значение {searchValue} найдено, позиция {counter + 1} массива");
                return counter;
            }
            else
            {
                Console.WriteLine("Искомое значение не найдено");
                return 0;
            }
        }
    }
}