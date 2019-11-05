using System;
using UserInteraction;

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
            ConsoleInteraction ask = new ConsoleInteraction();
                      
            int num1 = ask.GetValueInt("Введите числитель дроби #1: ");
            int den1 = ask.GetDenominator("Введите знаменатель дроби #1: ");
            int num2 = ask.GetValueInt("Введите числитель дроби #2: ");
            int den2= ask.GetDenominator("Введите знаменатель дроби #2: ");

            NaturalFraction dig1 = new NaturalFraction(num1, den1);
            NaturalFraction dig2 = new NaturalFraction(num2, den2);
            Console.WriteLine($"\nВведены две дроби: {dig1.ConvertToString(false)}, {dig2.ConvertToString(false)}");

            bool ansContinue;
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
}