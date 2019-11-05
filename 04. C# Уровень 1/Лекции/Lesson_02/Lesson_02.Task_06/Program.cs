using System;

// цикл While

namespace Lesson_02.Exp_06
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            while (n != 0)
            {
                count++;
                n = n / 10;// так как n-целое, деление целочисленное	
            }
            Console.WriteLine(count);
        }
    }
}
