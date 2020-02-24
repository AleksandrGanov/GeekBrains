// Определение средней оценки с помощью цикла While

using System;

using static mlConsole.GetData;

namespace Lesson01.Exp05
{
    class Program
    {
        static void Main()
        {
            uint counter = 1;
            int grade, sum = 0;
         
            while (counter <= 10)
            {
                grade = GetValueInt("Введите оценку: ");
                sum += grade;
                counter++;
            }

            Console.WriteLine($"Средняя оценка: {sum / 10d:F2}" );
            Console.ReadLine();
        }
    }
}