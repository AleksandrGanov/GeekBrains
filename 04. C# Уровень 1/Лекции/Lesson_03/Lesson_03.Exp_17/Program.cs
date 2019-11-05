using System;

// Структура Point

namespace Lesson_03.Exp_17
{
    class Program
    {
        class Point
        {
            double _x, _y;

            public Point()
            {
                _x = _y = 0;
            }
            public Point(double x, double y)
            {
                _x = x;
                _y = y;
            }
            public void SetX(double value)
            {
                _x = value;
            }
            public double GetX()
            {
                return _x;
            }
            public double X
            {
                get { return _x; }
                set {
                    if (value > 0) _x = value;
                    else _x = -value;
                }
            }
            public double Distance(Point Z)
            {
                return Math.Sqrt(Math.Pow(_x - Z._x, 2) + Math.Pow(_y - Z._y, 2));
            }
            public override string ToString()
            {
                return _x + "," + _y;
            }
        }

        static void Main(string[] args)
        {
            Point C = new Point();
            C.SetX(10);
            Console.WriteLine(C.GetX());
            Console.WriteLine(C.X);
            C.X = 10;
            Console.WriteLine(C);

            Point A = new Point();
            Point B = new Point(2, 2);
            Console.WriteLine(A.Distance(B));
            Console.ReadKey();
        }
    }
}