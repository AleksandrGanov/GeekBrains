using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Структура Point

namespace Lesson_03.Exp_16
{
    class Program
    {
        struct Point
        {
           public double _x, _y;

            public Point(double x, double y)
            {
                _x = x;
                _y = y;
            }

            public double Distance(Point Z)
            {
                return Math.Sqrt(Math.Pow(_x - Z._x, 2) + Math.Pow(_y - Z._y, 2));
            }
        }

        static void Main(string[] args)
        {
            Point A = new Point(1, 1);
            Point B = new Point(100, 100);
            Console.WriteLine($"Расстояние между точкам {A.Distance(B):F2}") ;
            Console.ReadLine();
        }
    }
}
