using System;

/* Описание задания:
Ганов Александр Анатольевич
====================
а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
в) Добавить диалог с использованием switch демонстрирующий работу класса.
 */

namespace Lesson_03.HW_Task_02
{
    class Program
    {
        static void Main()
        {
            UserInteraction ask = new UserInteraction();
            Double real1 = ask.GetValueDouble("Введите реальную часть комплексного числа #1: ");
            Double img1 = ask.GetValueDouble("Введите мнимую часть комплексного числа #1: ");
            Double real2 = ask.GetValueDouble("Введите реальную часть комплексного числа #2: ");
            Double img2 = ask.GetValueDouble("Введите мнимую часть комплексного числа #2: ");

            ComplexClass dig1 = new ComplexClass(real1, img1);
            ComplexClass dig2 = new ComplexClass(real2, img2);
            Console.WriteLine($"\nВведены два комплексных числа: {dig1.ConvertToString()}, {dig2.ConvertToString()}");

            do
            {
                Console.WriteLine("\nВ программе предусмотрены следующие арифметические операции:"
                    + "\n1 - Сложение"
                    + "\n2 - Вычитание"
                    + "\n3 - Умножение"
                    + "\n4 - Деление"
                    );
                int ans = ask.GetValueInt("Выберите необходимое действие: ");

                switch (ans)
                {
                    case 1:
                        Console.WriteLine($"\nРезультат сложения: {dig1.Add(dig2).ConvertToString()}");
                        break;
                    case 2:
                        Console.WriteLine($"\nРезультат вычитания: {dig1.Substract(dig2).ConvertToString()}");
                        break;
                    case 3:
                        Console.WriteLine($"\nРезультат умножения: {dig1.Multiply(dig2).ConvertToString()}");
                        break;
                    case 4:
                        Console.WriteLine($"\nРезультат деления: {dig1.Devide(dig2).ConvertToString()}");
                        break;
                }

            } while (ask.AskUser("Желаете выполнить еще какие-либо действия? (введите y/n)").ToLower() == "y");
        }

        class ComplexClass
        {
            public double re;
            public double im;

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
        struct UserInteraction
        {
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
        }
    }
}
