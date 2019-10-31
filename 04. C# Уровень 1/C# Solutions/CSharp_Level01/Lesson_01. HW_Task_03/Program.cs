using System;

/* Описание задания:
Ганов Александр Анатольевич
====================
а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
    по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
    Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
 */

namespace Lesson_01.HW_Task_03
{
    class Program
    {
        static void Main()
        {
            int x1 = Convert.ToInt32(AskUser("Введите x1"));
            int y1 = Convert.ToInt32(AskUser("Введите y1"));
            int x2 = Convert.ToInt32(AskUser("Введите x2"));
            int y2 = Convert.ToInt32(AskUser("Введите y2"));
            double r = CalcDistance(x1, y1, x2, y2);

            Console.WriteLine($"Расстояние равно: {r:F2} ед.");
            Console.ReadLine();
        }

        static string AskUser(string str)
        {
            Console.Write(str + ": ");
            return Console.ReadLine();
        }

        static double CalcDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
