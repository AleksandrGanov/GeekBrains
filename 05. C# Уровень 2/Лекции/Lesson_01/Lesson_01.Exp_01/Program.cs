// Создание класса

using System;
namespace Class_Vector0010
{
    class Vector
    {
        public double X;
        public double Y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector();
            v1.X = 10;
            v1.Y = 5;
            Vector v2;
            v2 = new Vector();
            v2.X = -5;
            v2.Y = -10;
        }
    }
}