using System;
using System.Text.RegularExpressions;

// Пример программы с использованием регулярных выражений

namespace Lesson_05.Exp_12
{
    class Program
    {
        static void Main()
        {
            string data1 = "Петр, Андрей, Николай";
            string data2 = "Петр, Андрей, Александр";
            Regex regex = new Regex("Николай");     // Создание регулярного выражения
            Console.WriteLine(regex.IsMatch(data1)); // True
            Console.WriteLine(regex.IsMatch(data2)); // False
            Console.ReadLine();
        }
    }
}