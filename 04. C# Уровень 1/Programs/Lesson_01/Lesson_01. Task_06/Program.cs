using System;

// Написать программу для подсчета площади треугольника

namespace Lesson_01.Task_06
{
    class Program
    {
        static bool IsTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && c + b > a;
        }
        static double S(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        static void Main(string[] args)
        {
            Console.Write("Введите a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите c:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Может существовать треугольник с такими сторонами:" + IsTriangle(a, b, c));
            Console.WriteLine("Площадь треугольника: {0:F2}", S(a, b, c));
            Console.ReadLine();
        }
    }
}
