using System;

// Пример структуры в C#, представляющей комплексное число и несколько действий с ним

namespace Lesson_03.Exp_04
{
    struct Complex
    {
        public double re;
        public double im;

        //  cложение КЧ
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        //  произведение КЧ
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public string ConvertToString()
        {
            return re + "+" + im + "i";
        }
    }

    class Program
    {
        static void Main()
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ConvertToString());
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ConvertToString());
            Console.ReadLine();
        }
    }
}
