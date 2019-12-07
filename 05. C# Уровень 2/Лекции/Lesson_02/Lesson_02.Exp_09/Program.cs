// Интерфейс ICloneable (поверхностное, не глубокое копирование)
// применяется только для примитивных типов

using System;

namespace Lesson_02.Exp_09
{
    class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public object Clone()
        {
            return new Person { Name = Name, Age = Age };
            // return MemberwiseClone(); // можно использовать алтернативный метод для копирования всех полей
        }
    }

    class Program
    {
        static void Main()
        {
            Person p1 = new Person { Name = "Tom", Age = 23 };
            Person p2 = (Person)p1.Clone();
            p2.Name = "Alice";
            Console.WriteLine(p1.Name); // Tom
            Console.WriteLine(p2.Name); // Alice
            Console.Read();
        }
    }
}