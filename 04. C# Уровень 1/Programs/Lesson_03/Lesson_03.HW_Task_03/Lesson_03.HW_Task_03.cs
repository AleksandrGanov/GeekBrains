using System;

/* Описание задания:
Ганов Александр Анатольевич
====================
Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
Предусмотреть методы сложения, вычитания, умножения и деления дробей.
Написать программу, демонстрирующую все разработанные элементы класса.
Добавить свойства типа int для доступа к числителю и знаменателю;
Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
Добавить упрощение дробей
 */

namespace Lesson_03.HW_Task_03
{
    class Program
    {
        static void Main()
        {
            UserInteraction ask = new UserInteraction();
            int den1, num1, den2, num2;
            bool ansContinue;

            num1 = ask.GetValueInt("Введите числитель дроби #1: ");
            den1 = ask.GetDenominator("Введите знаменатель дроби #1: ");
            num2 = ask.GetValueInt("Введите числитель дроби #2: ");
            den2= ask.GetDenominator("Введите знаменатель дроби #2: ");

            NaturalFraction dig1 = new NaturalFraction(num1, den1);
            NaturalFraction dig2 = new NaturalFraction(num2, den2);
            Console.WriteLine($"\nВведены две дроби: {dig1.ConvertToString(false)}, {dig2.ConvertToString(false)}");

            do
            {
                Console.WriteLine("\nВ программе предусмотрены следующие операции с дробями:"
                    + "\n1 - Сложение"
                    + "\n2 - Вычитание"
                    + "\n3 - Умножение"
                    + "\n4 - Деление"
                    + "\n5 - Упрощение"
                    + "\n6 - Вывод в виде десятичной дроби"
                    );
                int ans = ask.GetValueInt("Выберите необходимое действие: ");

                switch (ans)
                {
                    case 1:
                        Console.WriteLine($"\nРезультат сложения: {dig1.Add(dig2).ConvertToString(true)}");
                        break;
                    case 2:
                        Console.WriteLine($"\nРезультат вычитания: {dig1.Substract(dig2).ConvertToString(true)}");
                        break;
                    case 3:
                        Console.WriteLine($"\nРезультат умножения: {dig1.Multiply(dig2).ConvertToString(true)}");
                        break;
                    case 4:
                        Console.WriteLine($"\nРезультат деления: {dig1.Devide(dig2).ConvertToString(true)}");
                        break;
                    case 5:
                        Console.WriteLine($"\nУпрощенные дроби: {dig1.ConvertToString(true)},  {dig2.ConvertToString(true)}");
                        break;
                    case 6:
                        Console.WriteLine($"\nУпрощенные дроби: {dig1.DecimalFraction.ToString().Replace(',', '.')},  {dig2.DecimalFraction.ToString().Replace(',', '.')}");
                        break;
                    default:
                        Console.WriteLine($"Функция с кодом \"{ans}\" отсутствует в программе");
                        break;
                }
                ansContinue = ask.AnsYesNo("Желаете выполнить еще какие-либо действия? (y/n)");

            } while (ansContinue);
        }
    }
    class NaturalFraction
    {
        int num; // numerator
        int den; //denominator

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
    struct UserInteraction
    {
        /// <summary>
        /// Реализует выдачу ответа "Да/Нет" на запрос пользователя
        /// </summary>
        /// <param name="question">Вопросы, выводимый пользователю</param>
        /// <returns>булево True/False</returns>
        public bool AnsYesNo(string question)
        {
            string ans;
            ans = AskUser(question).ToLower();
            while (!(ans == "y" || ans == "n"))
            {
                ans = AskUser("Введите \"y\" или \"n\", другие ответы не допускаются").ToLower();
            }
            if (ans == "y") return true; else return false;
        }
        /// <summary>
        /// Вывод запроса пользователю через консоль и возврат результата ввода
        /// </summary>
        /// <param name="str">вопрос пользователю</param>
        /// <returns>ответ пользователя</returns>
        public string AskUser(string str)
        {
            Console.Write(str + ": ");
            return Console.ReadLine();
        }
        public int GetDenominator(string str)
        {
            int den;
            do
            {
                den = GetValueInt(str);
                try
                {
                    if (den==0) throw new Exception($"Знаменатель не может быть равен нулю, введите другое число");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            } while (den == 0);
            return den;
        }
        /// <summary>
        /// Запрос значения "Int" через консоль с проверкой на тип значения
        /// </summary>
        /// <param name="msg">Сообщение, выдаваемое пользователю</param>
        /// <returns>Введенное в консоль значение</returns>
        public int GetValueInt(string msg)
        {
            int x; bool flag;
            do
            {
                Console.Write(msg);
                flag = int.TryParse(Console.ReadLine(), out x);
            }
            while (!flag);  //  Пока false(!false=true), повторять цикл
            return x;
        }
        /// <summary>
        /// Запрос значения "Double" через консоль с проверкой на тип значения
        /// </summary>
        /// <param name="msg">Сообщение, выдаваемое пользователю</param>
        /// <returns>Введенное в консоль значение</returns>
        public double GetValueDouble(string msg)
        {
            double x; bool flag;
            do
            {
                Console.Write(msg);
                flag = double.TryParse(Console.ReadLine(), out x);
            }
            while (!flag);  //  Пока false(!false=true), повторять цикл
            return x;
        }
        /// <summary>
        /// Проверяет значение на ноль и выводит сообщение в консоль
        /// </summary>
        /// <param name="str">Начальное слово фразы "......... не может быть равен нулю, введите другое число"</param>
        /// <param name="dig">Проверяемое значение</param>
        public void IfZero(string str, dynamic dig)
        {
            if (dig == 0) Console.WriteLine($"{str} не может быть равен нулю, введите другое число");
        }
    }
}