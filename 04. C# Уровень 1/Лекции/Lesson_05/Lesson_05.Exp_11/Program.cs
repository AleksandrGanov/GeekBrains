using System;
using System.Text;

// Изменямые строки System.Text.StringBuilder (замер производительности)

namespace Lesson_05.Exp_11
{
    class StringBuilderAppend
    {
        const int iIterations = 10000;
        public static void Main()
        {
            DateTime dt = DateTime.Now;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < iIterations; i++)
                sb.Append("abcdefghijklmnopqrstuvwxyz\r\n");
            string str = sb.ToString();
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadLine();
        }
    }
}
