using System;
using System.Runtime.InteropServices;

// Написать программу сложения двух чисел

namespace Lesson_01.Exp_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double x,y;
            Console.Write("Введите первое число: ");
            string str = Console.ReadLine();
            x = Convert.ToDouble(str);
            Console.Write("Введите второе число: ");
            y = Convert.ToDouble(Console.ReadLine());
            double z = x + y;
            Console.WriteLine(x + "+" + y + "=" + z);     // Преобразование в строку
            Console.ReadLine();
        }
    }
}