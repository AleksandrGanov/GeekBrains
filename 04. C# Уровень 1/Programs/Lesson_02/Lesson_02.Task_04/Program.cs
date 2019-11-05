using System;

//оператор выбора

namespace Lesson_02.Exp_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseSwitch = 1;
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}
