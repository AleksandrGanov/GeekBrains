using System;

/// <summary>
/// 
/// </summary>
namespace Lesson_03.HW_Task_03
{
    class NaturalFraction
    {
        int num; // numerator
        int den; // denominator

        /// <summary>
        /// Значение числителя дроби
        /// </summary>
        public int Numerator
        {
            get => num;
            set => num = Numerator;
        }
        /// <summary>
        /// Значение знаменателя дроби
        /// </summary>
        public int Denominator
        {
            get => den;
            set => den = Denominator;
        }
        /// <summary>
        /// Значение знаменателя дроби
        /// </summary>
        public double DecimalFraction
        {
            get => Math.Round((double)num / den, 2);
        }

        public NaturalFraction()
        {
            num = 0;
            den = 0;
        }
        public NaturalFraction(int num, int den)
        {
            this.num = num;
            this.den = den;
        }
        public NaturalFraction Add(NaturalFraction x2)
        {
            NaturalFraction x3 = new NaturalFraction();
            if (den == x2.den)
            {
                x3.num = num + x2.num;
                x3.den = den;
                return x3;
            }
            else
            {
                x3.num = (num * x2.den + x2.num * den);
                x3.den = den * x2.den;
                return x3;
            }
        }
        public NaturalFraction Substract(NaturalFraction x2)
        {
            NaturalFraction x3 = new NaturalFraction();
            if (den == x2.den)
            {
                x3.num = num - x2.num;
                x3.den = den;
                return x3;
            }
            else
            {
                x3.num = (num * x2.den - x2.num * den);
                x3.den = den * x2.den;
                return x3;
            }
        }
        public NaturalFraction Multiply(NaturalFraction x2)
        {
            NaturalFraction x3 = new NaturalFraction();
            x3.num = x2.num * num;
            x3.den = x2.den * den;
            return x3;
        }
        public NaturalFraction Devide(NaturalFraction x2)
        {
            NaturalFraction x3 = new NaturalFraction();
            x3.num = num * x2.den;
            x3.den = den * x2.num;
            return x3;
        }
        /// <summary>
        /// Вычисляет наибольший общий делитель числителя и знаменателя
        /// </summary>
        /// <param name="num">Числитель</param>
        /// <param name="den">Знаменатель</param>
        /// <returns>НОД числителя и знаменателя</returns>
        int NOD(int num, int den)
        {
            while (num != den)
                if (num > den) num -= den; else den -= num;
            return num;
        }
        /// <summary>
        /// конвертирует дроби в стройковый формат с упрощение или без
        /// </summary>
        /// <param name="simplify">truе - упрощать, false - не упрощать</param>
        /// <returns>дробь в строковом формате</returns>
        public string ConvertToString(bool simplify)
        {
            int nod = NOD(Math.Abs(num), den);
            if (simplify && num > den)
            {
                num /= nod; den /= nod;
                if (num % den != 0) return num / den + "-" + num % den + "/" + den;
                else return (num / den).ToString();
            }
            else if (simplify && num <= den)
            {
                num /= nod; den /= nod;
                return num + "/" + den;
            }
            else return num + "/" + den;
        }
    }
}