using System;

using static mlConsole.GetData;
using static System.Math;

namespace Lesson01.Exp01
{
    class Program
    {
        static int Main()
        {
            Point p1 = new Point
            {
                x = GetValueDouble("Введите координату x1: "),
                y = GetValueDouble("Введите координату y1: ")
            };
            Point p2 = new Point
            {
                x = GetValueDouble("Введите координату x2: "),
                y = GetValueDouble("Введите координату y2: ")
            };
            Point p3 = new Point
            {
                x = GetValueDouble("Введите координату x3: "),
                y = GetValueDouble("Введите координату y3: ")
            };

            Console.WriteLine($"Дистанция: {Distance(p1, p2):F2}");
            Console.WriteLine($"Периметр треугольника: {TrianglePerimetr(p1, p2, p3):F2}");
            Console.ReadLine();
            return 0;
        }

        static double Distance(Point p1, Point p2)
        {
            return Sqrt(Pow(p1.x - p2.x, 2) + Pow(p1.y - p2.y, 2));
        }
        static double TrianglePerimetr(Point p1, Point p2, Point p3)
        {
            return Sqrt(Pow(p1.x - p2.x, 2) + Pow(p1.y - p2.y, 2))
                  + Sqrt(Pow(p1.x - p3.x, 2) + Pow(p1.y - p3.y, 2))
                  + Sqrt(Pow(p2.x - p3.x, 2) + Pow(p2.y - p3.y, 2));
        }
    }
    struct Point
    {
        public double x;
        public double y;
    }
}