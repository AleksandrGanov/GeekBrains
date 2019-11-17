// Пример делегата

using System;

namespace ConsoleApplication2
{
    class Program
    {
        static int Compare(int a, int b)
        {
            if (a % 10 > b % 10) return 1;
            if (a % 10 < b % 10) return -1;
            return 0;
        }

        static void Main(string[] args)
        {
            int[] a = new int[20];
            for (int i = 0; i < a.Length; i++) a[i] = i;
            Array.Sort(a, Compare);
            foreach (var el in a)
            {
                Console.Write("{0,4}", el);
            }
            Console.ReadLine();
        }
    }
}