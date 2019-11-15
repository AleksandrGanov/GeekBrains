using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Неизменямые строки System.String (методы Split, Join)

namespace Lesson_05.Exp_05
{
    class Program
    {
        static void Main()
        {
            string poems = "белеет парус одинокий в тумане моря голубом";
            char[] div = { ' ' }; // создаем массив разделителей
            string[] parts = poems.Split(div); // разбиваем строку на части
            Console.WriteLine("Результат разбиения строки на части: ");
            for (int i = 0; i < parts.Length; i++)
                Console.WriteLine(parts[i]);
            // собираем эти части в одну строку, в качестве разделителя используем символ |
            string str = String.Join("|", parts);
            Console.WriteLine("Результат сборки: ");
            Console.WriteLine(str);
        }
    }
}
