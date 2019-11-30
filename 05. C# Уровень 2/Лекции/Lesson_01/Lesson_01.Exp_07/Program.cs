// Наследование

using System;

namespace inheritance_0020
{
    class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector()
        {
            X = Y = 0;
        }
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
       
        public new string ToString() => $"X={X} Y={Y}";
    }
    class MyObject : Vector
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyObject obj1 = new MyObject
            {
                X = 10,
                Y = 20
            };
            Console.WriteLine(obj1.ToString());
            Console.ReadLine();
        }
    }
}