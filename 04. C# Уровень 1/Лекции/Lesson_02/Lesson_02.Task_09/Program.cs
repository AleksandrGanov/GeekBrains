using System;

// цикл foreach

namespace Lesson_02.Exp_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello, Foreach";
            foreach (char c in s)
                Console.Write("{0} ", c);
        }
    }
}
