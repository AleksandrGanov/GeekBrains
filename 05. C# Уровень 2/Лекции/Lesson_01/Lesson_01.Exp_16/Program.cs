// Простой практический пример использования полиморфизма

using System;

namespace Override_ToString
{
    class MyClass : Object
    {
        private int _a;
        public MyClass(int a)
        {
            _a = a;
        }
        // Попробуйте раскомментировать этот метод и запустить программу
        public override string ToString() =>  _a.ToString();
    }
    class Program
    {
        static void Main()
        {
            MyClass obj = new MyClass(10);
            Console.WriteLine(obj);
            Console.ReadLine();
        }
    }
}