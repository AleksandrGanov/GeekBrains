// Полиморфизм

using System;

namespace Virtual_0010
{
    class MyObject
    {
        public virtual void Show()
        {
            Console.WriteLine("Я - виртуальный метод Show");
        }
    }
    class MyObject2 : MyObject
    {
        public override void Show()
        {
            Console.WriteLine("Я - переопределенный метод Show");
        }
    }
    class Program
    {
        static void Main()
        {
            MyObject obj1 = new MyObject();
            MyObject2 obj2 = new MyObject2();
            // Вызываем метод Show объекта класса MyObject
            obj1.Show();
            // Вызываем метод Show объекта класса MyObject2
            obj2.Show();
            // Демонстрируем полиморфизм
            // Объекты базовых классов могут ссылаться на объекты производных классов
            MyObject obj3 = new MyObject2();
            // Но при вызове метода будет вызываться переопределенный метод
            obj3.Show();
        }
    }
}