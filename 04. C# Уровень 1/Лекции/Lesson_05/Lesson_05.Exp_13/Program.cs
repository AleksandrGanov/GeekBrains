using System;
using System.Text.RegularExpressions;

// Пример программы с использованием регулярных выражений (проверка, что введённый email-адрес правильный)

namespace Lesson_05.Exp_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex myReg = new Regex(@"[A-Za-z]+[\.A-Za-z0-9_-]*[A-Za-z0-9]+@[A-Za-z0-9]+\.[A-Za-z]{2,6}");
            Console.WriteLine(myReg.IsMatch("email@email.com"));// True
            Console.WriteLine(myReg.IsMatch("email@email"));        // False
            Console.WriteLine(myReg.IsMatch("@email.com"));         // False
            Console.ReadKey();
        }
    }
}
