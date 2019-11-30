// IS и AS #1

using System;

namespace IsAs
{
    class MyObject
    {
    }
    class MyObject2 : MyObject
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Здесь все понятно
            MyObject obj1 = new MyObject();
            MyObject2 obj2 = new MyObject2();
            
            if (obj1 is MyObject) Console.WriteLine("obj1 является объектом класса MyObject");
            else Console.WriteLine("obj1 не является объектом класса MyObject");
            if (obj2 is MyObject2) Console.WriteLine("obj2 является объектом класса MyObject2");
            else Console.WriteLine("obj2 не является объектом класса MyObject2");

            // Здесь мы демонстрируем полиморфизм
            // Объекты базовых классов могут ссылаться на объекты производных классов
            MyObject obj3 = new MyObject2();

            if (obj3 is MyObject) Console.WriteLine("obj3 является объектом класса MyObject");
            else Console.WriteLine("obj3 не является объектом класса MyObject");
        }
    }
}
