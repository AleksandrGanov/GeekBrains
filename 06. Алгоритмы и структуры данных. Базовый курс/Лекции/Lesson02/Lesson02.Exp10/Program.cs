// Рекурсия, пример №5. Рекурсивный перебор

using System;

namespace Lesson02.Exp10
{
    class Program
    {
        static readonly int wordLen = 3;
        static readonly string alfabet = "more";
        static int counter = 0;

        static void Main()
        {
            FindWords(alfabet,wordLen);
            Console.ReadLine();
        }
        static void FindWords(string alfabet, int wordLen, int N=0)
        {
            if (N == wordLen) counter++;
        }
    }
}