using System;

/* Описание задания:
Ганов Александр Анатольевич
====================
С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел
 */

namespace Lesson_02.HW_Task_03
{
    class Program
    {
        static void Main()
        {
            int num;
            int counter = 0;
            do
            {
                num = Convert.ToInt32(AskUser("Введите целое число^"));
                if (num % 2 != 0 && num > 0) counter++;
            } while (num != 0);

            Console.WriteLine($"Количество положительных нечетных чисел: {counter}");
            Console.ReadLine();
        }

        public static string AskUser(string str)
        {
            Console.Write(str);
            return Console.ReadLine();
        }
    }
}
