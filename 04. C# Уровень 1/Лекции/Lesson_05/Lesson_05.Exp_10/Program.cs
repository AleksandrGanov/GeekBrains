using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Неизменямые строки System.String(замер производительности)

namespace Lesson_05.Exp_10
{
    class StringAppend
    {
        const int iIterations = 10000;
        public static void Main()
        {
            DateTime dt = DateTime.Now;
            string str = String.Empty;
            for (int i = 0; i < iIterations; i++)
                str += "abcdefghijklmnopqrstuvwxyz\r\n";
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadLine();
        }
    }
}