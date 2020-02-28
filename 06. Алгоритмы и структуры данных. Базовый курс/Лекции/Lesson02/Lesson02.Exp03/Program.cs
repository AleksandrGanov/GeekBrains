// Правило №3. Если алгоритму необходимо сделать O(f(N) + g(N)) шагов, и область значений N функции f(N) больше,
// чем у g(N), то асимптотическую сложность можно упростить до выражения O(f(N))

using System;

using static mlArray.ArrMaker;
using static mlConsole.PrintData;

namespace Lesson02.Exp03
{
    class Program
    {
        static int steps = 0;

        static void Main()
        {
            int[] arr = IntRndArray(300, 1, 100);
            int maxVal = FindMax(arr);
            Console.WriteLine($"Сгенеренный массив:"); ArrPrint<int>(arr, 10);
            if ((steps - 2) > 2) steps -= 2; // Проверка правила №3
            Console.WriteLine($"Макс.значение {maxVal}, Кол-во шагов: {steps}");
            Console.ReadLine();
        }
        static int FindMax(int[] intArr)
        {
            int maxVal = intArr[0]; steps++;
            steps++; // Присваиваем значение переменной i
            for (int i = 0; i < intArr.Length; i++)
            {
                steps++;
                if (intArr[i] > maxVal) maxVal = intArr[i];
            }
            steps++; return maxVal;
        }
    }
}