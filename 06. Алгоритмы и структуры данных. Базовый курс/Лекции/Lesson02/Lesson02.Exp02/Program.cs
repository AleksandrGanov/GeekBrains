// Правило №2. Если алгоритм выполняет одну операцию, состоящую из O(f(N)) шагов, а затем вторую операцию,
// включающую O(g(N)) шагов, то общая производительность алгоритма для функций f и g составит O(f(N) + g(N))

using System;

using static mlArray.ArrMaker;
using static mlConsole.PrintData;

namespace Lesson02.Exp02
{
    class Program
    {
        static int steps = 0;

        static void Main()
        {
            int[] arr = IntRndArray(20, 1, 100);
            int maxVal = FindMax(arr);
            Console.WriteLine($"Сгенеренный массив:"); ArrPrint<int>(arr, 10);
            Console.WriteLine($"Макс.значение {maxVal}, Кол-во шагов: {steps}");
            Console.ReadLine();
        }
        static int FindMax(int[] intArr)
        {
            int maxVal = intArr[0]; steps++;
            for (int i = 0; i < intArr.Length; i++)
            {
                steps++;
                if (intArr[i] > maxVal) maxVal = intArr[i];
            }
            steps++; return maxVal;
        }
    }
}