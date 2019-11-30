// Перегрузка операторов

using System;

namespace Vectors
{
    // Введем структуру Vector и перегрузим для нее операции +, -, =
    class Vector
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Vector()
        {
            X = Y = 0;
        }
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Ключевое слово implicit служит для объявления неявного оператора преобразования пользовательского типа. Этот оператор обеспечивает неявное преобразование между пользовательским типом и другим типом, если при преобразовании исключается утрата данных    
        // explicit - Ключевое слово для объявления явного оператора преобразования. Значит, мы указываем на потерю данных.

        public static explicit operator Vector(double x) => new Vector(x, x);
        public static implicit operator double(Vector x) => x.X;
        public override string ToString() => $"X= {X} Y= {Y}";

        // Перегрузка бинарного оператора +
        public static Vector operator +(Vector v1, Vector v2)
        {
            Vector res = new Vector
            {
                X = v1.X + v2.X,
                Y = v1.Y + v2.Y
            };
            return res;
        }
        // Перегрузка бинарного оператора -
        public static Vector operator -(Vector v1, Vector v2)
        {
            Vector res = new Vector
            {
                X = v1.X - v2.X,
                Y = v1.Y - v2.Y  // Ошибка
            };
            return res;
        }
        // Перегрузка унарного оператора -
        public static Vector operator -(Vector v1)
        {
            Vector res = new Vector
            {
                X = -1 * v1.X,
                Y = -1 * v1.Y
            };
            return res;
        }
    }

    class Program
    {
        static void Main()
        {
            // Создаем вектор
            Vector v1 = new Vector(-5, 5);
            // Другой вектор задаем, используя перегрузку = explict
            Vector v2 = (Vector)10;
            Vector v3 = v1 + v2; // Проверяем работу +

            // Демонстрация доступа к закрытым полям через свойства
            Console.WriteLine($"v1.x={v1.X} v1.y={v1.Y}");
            Console.WriteLine($"(v1+v2):{v3}"); // Ошибка
            Console.WriteLine($"-(v1+v2):{-v3}"); // и -
            Console.ReadKey();
        }
    }
}