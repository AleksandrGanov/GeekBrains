using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Описание задания:
Ганов Александр Анатольевич
====================
Ввести вес и рост человека. 
Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
где m — масса тела в килограммах, h — рост в метрах.
 */

namespace Lesson_01.HW_Task_02
{
    class Program
    {
        static void Main()
        {
            double h = Convert.ToDouble(AskUser("Введите Ваш рост в метрах"));
            double m = Convert.ToDouble(AskUser("Введите Ваш вес"));
            double I=m/Math.Pow(h,2);
            
            Console.WriteLine($"Ваш ИМТ: {I:F2}");
            Console.ReadLine();
        }

        static string AskUser(string str)
        {
            Console.Write(str + ": ");
            return Console.ReadLine();
        }
    }
}
