// Интерфейс IDisposable

using System;

namespace Lesson_02.Exp_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            Console.ReadLine();
        }

        private static void Test()
        {
            Person p = null;
            try
            {
                p = new Person();
            }
            finally
            {
                if (p != null)
                {
                    p.Dispose();
                }
            }
        }
    }

    public class Person : IDisposable
    {
        public string Name { get; set; }
        public void Dispose()
        {
            Console.Beep();
            Console.WriteLine("Disposed");
        }
    }
}