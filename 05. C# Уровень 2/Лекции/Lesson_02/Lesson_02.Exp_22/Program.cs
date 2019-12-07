// Пример использования абстрактного класса и абстрактного метода в задаче вывода значений некоторой функции

// Универсальный метод вывода таблицы значений функции можно реализовать с помощью 
// абстрактного базового класса, содержащего два метода: метод вывода таблицы и абстрактный
// метод, задающий вид вычисляемой функции

using System;

namespace AbstractClass
{
    abstract class TableFun
    {
        public abstract double F(double x);
        public void Table(double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
    }
    class SimpleFun : TableFun
    {
        public override double F(double x)
        {
            return x * x;
        }
    }
    class SinFun : TableFun
    {
        public override double F(double x)
        {
            return Math.Sin(x);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TableFun a = new SinFun();
            Console.WriteLine("Таблица функции Sin:");
            a.Table(-2, 2);
            a = new SimpleFun();
            Console.WriteLine("Таблица функции Simple:");
            a.Table(0, 3);
            Console.ReadLine();
        }
    }
}