// Интерфейс ICloneable (глубокое копирование)

using System;

namespace Lesson_02.Exp_10
{

    class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Company Work { get; set; }

        public object Clone()
        {
            // перед создание клона создаем новый экземпляр поля/свойства ссылочного типа
            // и только после этого создаем экземпляр класса, содержащего данное поле/свойство
            Company company = new Company { Name = Work.Name };
            return new Person
            {
                Name = Name,
                Age = Age,
                Work = company
            };
        }
    }

    class Company
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Tom", Age = 23, Work = new Company { Name = "Microsoft" } };
            Person p2 = (Person)p1.Clone();
            p2.Work.Name = "Google";
            p2.Name = "Alice";
            Console.WriteLine(p1.Name); // Tom
            Console.WriteLine(p1.Work.Name); // Google - а должно быть Microsoft
            Console.ReadLine();
        }
    }
}
