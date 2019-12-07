// Интерфейс IComparable

using System;

namespace Lesson_02.Exp_06
{
    class Person : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CompareTo(object o)
        {
            Person p = o as Person;
            if (p != null)
                return Age.CompareTo(p.Age);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Bill", Age = 34 };
            Person p2 = new Person { Name = "Tom", Age = 23 };
            Person p3 = new Person { Name = "Alice", Age = 21 };

            Person[] people = new Person[] { p1, p2, p3 };
            Array.Sort(people);

            foreach (Person p in people)
            {
                Console.WriteLine($"{p.Name} - {p.Age}");
            }
            Console.ReadLine();
        }
    }
}