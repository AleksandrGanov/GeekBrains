using System;

/* Описание задания:
Ганов Александр Анатольевич
====================
С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
    Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse
 */

namespace Lesson_03.HW_Task_02
{
    class Program
    {
        static void Main()
        {
            double digit;
            int counter = 0;
            UserInteraction ask;

            do
            {
                digit = ask.GetValueDouble("Введите любое число: ");
                if (digit % 2 != 0 && digit > 0) counter++;

            } while (digit != 0);
            Console.WriteLine($"Количество нечетных положительных чисел: {counter}");
            Console.ReadLine();
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
