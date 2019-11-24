using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace БыстрыйСтарт_Урок01
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Я хочу изучать C#");

            string a = Console.ReadLine();
            string b = Console.ReadLine();

            int num1 = Int32.Parse(a);
            int num2 = Int32.Parse(b);

            int result = num1 + num2;
            Console.WriteLine(result);
            result = num1*num2;
            Console.WriteLine(result);

            double avarage = (double)(num1 + num2) / 2;
            Console.WriteLine(avarage);

            Console.ReadLine();
        }
    }
}
