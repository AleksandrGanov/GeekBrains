// Структуры

namespace Struct_Vector0010
{
    struct Vector
    {
        public double X;
        public double Y;

        // В структурах не может быть описан свой конструктор без параметров    
        // public Vector()
        // {
        //    x = y = 0;
        // }
        // Конструктор, который будет заполнять поля объекта

         public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    class Program
    {
        static void Main()
        {
            // Для структур не нужно использовать ключевое слово new
            Vector v1;
            v1.X = 10;
            v1.Y = 5;
            Vector v2;
            // Хотя можно вызывать конструкторы, но у структур они нужны только для заполнения полей структуры            
            v2 = new Vector(-5, -10);
        }
    }
}