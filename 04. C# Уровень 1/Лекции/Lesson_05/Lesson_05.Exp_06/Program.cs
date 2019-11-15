using System;

// Неизменямые строки System.String (методы Compare и CompareTo)

namespace Lesson_05.Exp_06
{
    class Program
    {
        static void Main()
        {
            string s1 = "Hello1!";
            string s2 = "Hello!";
            // сравнение с использованием статического метода
            Console.WriteLine(String.Compare(s1, s2));
            // сравнение с использованием нестатического метода
            Console.WriteLine(s1.CompareTo(s2));
            Console.WriteLine();
        }
    }
}
