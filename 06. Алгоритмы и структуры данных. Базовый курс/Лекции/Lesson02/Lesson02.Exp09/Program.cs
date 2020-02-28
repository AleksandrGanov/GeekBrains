// Рекурсия, пример №4. Числа Фибоначчи

using System;

namespace Lesson02.Exp09
{ 
    class Program
    {
        static readonly int maxValue = 30;

        static void Main()
        {
            for (int i = 0; i < maxValue; i++) Console.WriteLine($"i={i}: {FIBRec(i).ToString()}-{FIBCycle(i).ToString()}");
            Console.ReadLine();
        }
        static int FIBRec(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return FIBRec(n-1)+ FIBRec(n-2);
        }
        static int FIBCycle(int n)
        {
            int[] arr = new int[maxValue];
            arr[0] = 0; arr[1] = 1;
            for (int i = 2; i < arr.Length; i++) arr[i] = arr[i - 1] + arr[i - 2];
            return arr[n];
        }
    }
}