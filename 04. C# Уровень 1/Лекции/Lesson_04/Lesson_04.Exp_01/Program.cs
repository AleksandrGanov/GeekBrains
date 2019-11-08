using System;

// Пример работы с параметром out

namespace Lesson_04.Exp_01
{
    class Program
    {
        static void Main()
        {
            int l;
            Console.WriteLine(BackData("проверка", out l));
            Console.WriteLine(l);
            Console.ReadLine();

            int[] arr = new int[4];
        }

        private static bool BackData(string str, out int t)
        {
            t = 2;
            if (str == "проверка") return true;
            else return false;
        }
    }
}
