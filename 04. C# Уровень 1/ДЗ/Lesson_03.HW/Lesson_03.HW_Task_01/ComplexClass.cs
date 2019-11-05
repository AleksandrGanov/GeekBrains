using System;

namespace Lesson_03.HW_Task_02
{
    class ComplexClass
    {
        double re;
        double im;

        public ComplexClass()
        {
            re = 0;
            im = 0;
        }
        public ComplexClass(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public ComplexClass Add(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.re = re + x2.re;
            x3.im = im + x2.im;
            return x3;
        }
        public ComplexClass Substract(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.re = re - x2.re;
            x3.im = im - x2.im;
            return x3;
        }
        public ComplexClass Devide(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.re = (re * x2.re + im * x2.im) / (Math.Pow(x2.re, 2) + Math.Pow(x2.im, 2));
            x3.im = (x2.re * im - re * x2.im) / (Math.Pow(x2.re, 2) + Math.Pow(x2.im, 2));
            return x3;
        }
        public ComplexClass Multiply(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.re = re * x2.re - im * x2.im;
            x3.im = re * x2.im + x2.re * im;
            return x3;
        }
        public string ConvertToString()
        {
            return re + "+" + im + "i";
        }
    }
}
