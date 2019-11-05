using System;

// Класс для работы с комплексными числами. Вариант 1.

namespace Lesson_03.Exp_06
{
    class Program
    {
        static void Main()
        {
            Complex complex1 = new Complex();
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2 = new Complex();
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ConvertToString());
        }
    }

    class Complex
    {
        // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
        public double im;
        public double re;

        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        public string ConvertToString()
        {
            return re + "+" + im + "i";
        }
    }
}
