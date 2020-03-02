// Поиск в массиве. Поиск с барьером

using System;

using static mlArray.ArrMaker;
using static mlConsole.GetData;
using static mlConsole.PrintData;

namespace Lesson03.Exp02
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Поиск с барьером\n------------------------");
            int arrMax = (int)GetValueUInt("Введите размер массива: ");
            int barValue;
            do
            {
                barValue = (int)GetValueUInt("Введите размер барьера >100: ");
            } while (barValue <= 100);

            int[] arr = IntRndArrayWithBarrier(arrMax, 1, 100,barValue);
            Console.Write($"Сгенерирован массив. "); ArrPrint<int>(arr, 5);
            int searchVal = (int)GetValueUInt("Введите искомое значение: ");
            FindValueWithBarrier(arr, searchVal, barValue);
            Console.ReadLine();
        }
        static int FindValueWithBarrier(int[] arr, int searchValue, int barValue)
        {
            int counter = 0;
            while (arr[counter] != searchValue) counter++;
            if (counter != barValue)
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