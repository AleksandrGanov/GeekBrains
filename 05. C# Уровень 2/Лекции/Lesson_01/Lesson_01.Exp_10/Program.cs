// Наследование включением (агрегация)

using System;

namespace Inheritance_Incloser_0010
{
    // Пример наследования
    class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        // Переопределим конструктор по умолчанию        
        public Vector()
        {
            X = Y = 0;
        }
        // Конструктор, который будет заполнять поля объекта
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
        // Метод для получения данных в строковой форме
        public new string ToString() => String.Format($"X={X} Y={Y}");
    }

    class MyObject
    {
        public Vector Pos { get; set; }
        private double _width;
        private double _height;
        public MyObject(double width, double height, Vector v)
        {
            _width = width;
            _height = height;
            Pos = v;
        }
        // Переопределим метод, который выводит информацию о нашем поле в виде строки
        public new string ToString() => $"width:{_width} height:{_height} {Pos.ToString()}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyObject obj1 = new MyObject(10, 20, new Vector(1, 1));
            // Теперь доступ к полям можно осуществить через поле pos
            obj1.Pos.X = 10;
            obj1.Pos.Y = 20;
            Console.WriteLine(obj1.ToString());
            Console.ReadLine();
        }
    }
}