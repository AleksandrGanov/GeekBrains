// Методы доступа к закрытым данным

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
        
        // С версии C# 6.0 появилась новая функциональность - встроенные методы, или Expression-Bodied Methods.
        // Они позволяют применять лямбда-выражения для сокращенного написания методов в одну строку.
        public double GetX() => _x;
        public void SetX(double value) => _x = value;
        public double GetY() => _y;
        public void SetY(double value) => _y = value;

        // Метод для получения данных в строковой форме
        public new string ToString() => $"X={_x} Y={_y}";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(10, 5);
            Vector v2;
            v2 = new Vector(-5, -10);
            v1.SetY(10);
            v2.SetX(-10);
            Console.WriteLine($"v1:{v1.ToString()}");
            Console.WriteLine($"v2:{v2.ToString()}");
            Console.ReadLine();
        }
    }
}