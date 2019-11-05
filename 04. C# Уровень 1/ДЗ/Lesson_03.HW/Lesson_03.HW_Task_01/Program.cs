using System;
using UserInteraction;

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
            ConsoleInteraction ask = new ConsoleInteraction();
            Double real1 = ask.GetValueDouble("Введите реальную часть комплексного числа #1: ");
            Double img1 = ask.GetValueDouble("Введите мнимую часть комплексного числа #1: ");
            Double real2 = ask.GetValueDouble("Введите реальную часть комплексного числа #2: ");
            Double img2 = ask.GetValueDouble("Введите мнимую часть комплексного числа #2: ");

            ComplexClass dig1 = new ComplexClass(real1, img1);
            ComplexClass dig2 = new ComplexClass(real2, img2);
            Console.WriteLine($"\nВведены два комплексных числа: {dig1.ConvertToString()}, {dig2.ConvertToString()}");

            bool ansContinue;
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
                    default:
                        Console.WriteLine($"Функция с кодом \"{ans}\" отсутствует в программе");
                        break;
                }
                ansContinue = ask.AnsYesNo("Желаете выполнить еще какие-либо действия? (y/n)");
            } while (ansContinue);
        }
    }
}