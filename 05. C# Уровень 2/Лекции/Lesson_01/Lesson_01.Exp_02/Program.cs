// Конструкторы

namespace Class_Vector0010
{
    class Vector
    {
        // Теперь поля приватные
        private double _x;
        private double _y;
        // Переопределим конструктор по умолчанию        
        public Vector()
        {
            _x = _y = 0;
        }
        // Конструктор, который будет заполнять поля объекта
        public Vector(double x, double y)
        {
            _x = x;
            _y = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(10, 5);
            Vector v2;
            v2 = new Vector(-5, -10);
        }
    }
}