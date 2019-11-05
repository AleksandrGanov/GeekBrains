using System;

/* Описание задания:
Ганов Александр Анатольевич
====================
а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
    нужно ли человеку похудеть, набрать вес или всё в норме.
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
 */

namespace Lesson_02.HW_Task_05
{
    class Program
    {
        static void Main()
        {
            const double normIMTmin = 18.5;
            const double normIMTmaх = 24.9;
            double h = Convert.ToDouble(AskUser("Введите Ваш рост в метрах: "));
            double m = Convert.ToDouble(AskUser("Введите Ваш вес, кг: "));
            double IMT = m / Math.Pow(h, 2);

            Console.WriteLine($"Ваш ИМТ: {IMT:F2}");

            if (IMT > normIMTmaх)
            {
                Console.WriteLine($"У Вас избыточный вес!. Нужно сбросить {m - normIMTmaх * Math.Pow(h, 2) + 1:F2} кг.");
            }
            else if (IMT < normIMTmin)
            {
                Console.WriteLine($"У Вас недостаточный вес!. Нужно набрать {normIMTmin * Math.Pow(h, 2) + 1 - m:F2} кг.");
            }
            else
            {
                Console.WriteLine($"У Вас правильный вес, берегите здоровье!");
            }

            Console.ReadLine();
        }

        static string AskUser(string str)
        {
            Console.Write(str);
            return Console.ReadLine();
        }
    }
}
