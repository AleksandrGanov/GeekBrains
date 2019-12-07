// Интерфейс IComparer

using System;
using System.Collections.Generic;

namespace Lesson_02.Exp_08
{

    class Person : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CompareTo(object o)
        {
            if (o is Person p)
                return Name.CompareTo(p.Name);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }

    class PeopleComparer : IComparer<Person>
    {
        public int Compare(Person p1, Person p2)
        {
            if (p1.Name.Length > p2.Name.Length)
                return 1;
            else if (p1.Name.Length < p2.Name.Length)
                return -1;
            else
                return 0;
        }
    }

    class Program
    {
        static void Main()
        {
            Person p1 = new Person { Name = "Bill", Age = 34 };
            Person p2 = new Person { Name = "Tom", Age = 23 };
            Person p3 = new Person { Name = "Alice", Age = 21 };

            Person[] people = new Person[] { p1, p2, p3 };
            Array.Sort(people, new PeopleComparer());

            foreach (Person p in people)
            {
                Console.WriteLine($"{p.Name} - {p.Age}");
            }
            Console.ReadLine();
        }
    }
}
