using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_07.Exp_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, s = 0;

            for (i = 1, j = 5; i < j; ++i, --j)
            {
                s += i;
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
