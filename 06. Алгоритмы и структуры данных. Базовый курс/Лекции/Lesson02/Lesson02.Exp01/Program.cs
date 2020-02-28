// Правило №1. Если для математической функции f алгоритму необходимо выполнить определенные действия f(N)
// раз, то для этого ему понадобится сделать O(f(N)) шагов

using System;

using static mlArray.ArrMaker;
using static mlConsole.PrintData;

namespace Lesson02.Exp01
{
    class Program
    {
        static int steps = 0;

        static void Main()
        {
            int[] arr = IntRndArray(10, 1, 100);
            int maxVal=FindMax(arr);
            Console.WriteLine($"Сгенеренный массив:"); ArrPrint<int>(arr,5);
            Console.WriteLine($"Макс.значение {maxVal}, Кол-во шагов: {steps}");
            Console.ReadLine();
        }
        static int FindMax(int[] intArr)
        {
            int maxVal = intArr[0];
            for (int i = 0; i < intArr.Length; i++)
            {
                steps++;
                if (intArr[i] > maxVal) maxVal = intArr[i];
            }
            return maxVal;
        }
    }
}