/* Описание задания:
Ганов Александр Анатольевич
====================
Написать программу нахождения корней заданного квадратного уравнения
*/

using System;

using static mlConsole.GetData;

namespace Lesson01.HW.Task04
{
    class Program
    {
        static void Main()
        {
            double a = GetValueDouble("Введите коэффициент #1: ");
            double b = GetValueDouble("Введите коэффициент #2: ");
            double c = GetValueDouble("Введите коэффициент #3: ");
            double x1, x2;

            Console.WriteLine($"Решаем уравнение типа: {a}x^2+{b}x+{c}=0");
            
            double disk = Math.Pow(b, 2) - 4 * a * c;
            if (disk > 0)
            {
                double d = Math.Sqrt(disk);
                x1 = (d - b) / (2 * a);
                x2 = (-d - b) / (2 * a);
                Console.WriteLine($"Корни уравнения: x1={x1}, x2={x2}");
            }
            else Console.WriteLine("Уравнение не имеет корней");

            Console.ReadLine();
        }
    }
}