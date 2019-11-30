// Переопределение ToString()

using System;

namespace Override_010
{
    class MyObject
    {
        private int _a;
        public MyObject(int a)
        {
            _a = a;
        }
        // Запустите программу, закомментировав метод ToString
        public override string ToString() => $"a={_a}";
    }
    class Program
    {
        static void Main()
        {
            MyObject obj = new MyObject(2);
            Console.WriteLine(obj.ToString());
            Console.ReadLine();
        }
    }
}