using System;

namespace Lesson_06.HW_Task_01
{
    struct Functions
    {
        public static double MyFunc(double x, double y)
        {
            return y * Math.Pow(x, 2);
        }

        public static double MyFuncSin(double x, double y)
        {
            return y * Math.Sin(x);
        }

        public static void Table(Fun F, double x, double b, double y, double yMax)
        {
            Console.WriteLine($"Вызываем метод: {F.Method.Name}"); ;
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b && y <= yMax)
            {
                Console.WriteLine($"| {x,8:0.000} | {F(x, y),8:0.000} |");
                x += 1;
                y += 0.5;
            }
            Console.WriteLine("---------------------\n");
        }
    }
}