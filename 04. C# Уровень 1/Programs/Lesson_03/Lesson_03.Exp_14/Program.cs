using System;

// Задача 3. Написать программу табуляции произвольной функции в диапазоне от a до b (с использованием ООП)

namespace Lesson_03.Exp_14
{
    class Table
    {
        double a = -5;
        double b = 5;
        double h = 0.5;

        public Table()
        {
        }
        public Table(double a, double b, double h)
        {
            this.a = a;
            this.b = b;
            this.h = h;
        }

        double F(double x)
        {
            return 1 / x;
        }
        public void Show(double a, double b, double h)
        {
            Console.WriteLine("{0,10}{1,10}", "x", "F(x)");
            for (double x = a; x <= b; x = x + h)
            {
                Console.WriteLine("{0,10}{1,10:f3}", x, F(x));
            }
        }
        public void Show()
        {
            Console.WriteLine("{0,10}{1,10}", "x", "F(x)");
            for (double x = a; x <= b; x = x + h)
            {
                Console.WriteLine("{0,10}{1,10:f3}", x, F(x));
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Table table1 = new Table();
            table1.Show();
            Console.WriteLine("Для выполнения следующего расчета нажмите любую клавишу");
            Console.ReadKey();
            Table table2 = new Table(1, 2, 0.5);
            table2.Show();
            Console.ReadKey();
        }
    }

}
