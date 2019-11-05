using System;

namespace Lesson_03.HW_Task_02
{
    struct ComplexStruct
    {
        public double re;
        public double im;

        public ComplexStruct Add(ComplexStruct x2)
        {
            ComplexStruct x3 = new ComplexStruct();
            x3.re = re + x2.re;
            x3.im = im + x2.im;
            return x3;
        }
        public ComplexStruct Substract(ComplexStruct x2)
        {
            ComplexStruct x3 = new ComplexStruct();
            x3.re = re - x2.re;
            x3.im = im - x2.im;
            return x3;
        }
        public ComplexStruct Devide(ComplexStruct x2)
        {
            ComplexStruct x3 = new ComplexStruct();
            x3.re = (re * x2.re + im * x2.im) / (Math.Pow(x2.re, 2) + Math.Pow(x2.im, 2));
            x3.im = (x2.re * im - re * x2.im) / (Math.Pow(x2.re, 2) + Math.Pow(x2.im, 2));
            return x3;
        }
        public ComplexStruct Multiply(ComplexStruct x2)
        {
            ComplexStruct x3 = new ComplexStruct();
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
