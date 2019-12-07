// Деструктор класса 

using System;

namespace Lesson_02.Exp_11
{
    public class Person
    {
        public string Name { get; set; }

        ~Person()
        {
            Console.Beep();
            Console.WriteLine("Disposed");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test();
            GC.Collect();
            Console.ReadLine();
        }

        private static void Test()
        {
            Person p = new Person();
        }
    }
}
