using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// continue, break

namespace Lesson_02.Exp_10
{
    class Program
    {
        static void Main()
        {
            string s = "1. Привет, Foreach. \n2. А также break и continue! А это не выведется";
            foreach (char c in s)
            {
                // Пропускаем цифры
                if (c >= '0' && c <= '9') continue;
                // Если встречаем !, прерываем цикл
                if (c == '!') break;
                Console.Write("{0} ", c);
            }
        }
    }
}
