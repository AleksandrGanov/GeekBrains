// Свойства

using System;

namespace Class_Vector0010
{
    class Vector
    {
        private double _x;
        private double _y;

        public Vector()
        {
            _x = _y = 0;
        }
        public Vector(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double X
        {
            get => _x;
            set => _x = value;
        }
        public double Y
        {
            get => _y;
            set => _y = value;
        }
    }

    class Program
    {
        static void Main()
        {
            Vector v1 = new Vector(10, 5);
            Vector v2;
            v2 = new Vector(-5, -10);
            v1.X = 10;
            v2.X = -10;
            Console.WriteLine($"v1: X={v1.X} Y={v1.Y}"); // и при чтении
        }
    }
}