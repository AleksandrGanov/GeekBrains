using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Организовать ввод с «защитой от дурака»

namespace Lesson_03.Exp_03
{
    class Program
    {
        static int value;
        static string console_message = "Введите число: ";

        static void Main()
        {
            value = GetValue(console_message);
            ShowValue("Return: ") ;
            value = ReturnValue();
            ShowValue("Value после ReturnValue: ");
            value = GetValue(console_message);
            Console.WriteLine("Out parameter: ");
            OutParameter(out value);
            ShowValue("Value после OutParameter: ");
            Console.ReadLine();
        }

        static int GetValue(string msg)
        {
            int x; bool flag;
            do
            {
                Console.WriteLine(msg);
                flag = int.TryParse(Console.ReadLine(), out x);
            }
            while (!flag);  //  Пока false(!false=true), повторять цикл
            return x;
        }
        static void ShowValue(string description)
        {
            Console.WriteLine(description + value);
        }
        static int ReturnValue()
        {
            ShowValue("ReturnValue (до): ");
            int tmp = 10;
            ShowValue("ReturnValue (после): ");
            return tmp;
        }
        static void OutParameter(out int tmp)
        {
            ShowValue("OutParameter (до): ");
            tmp = 10;
            ShowValue("OutParameter (после): ");
        }
    }
}
