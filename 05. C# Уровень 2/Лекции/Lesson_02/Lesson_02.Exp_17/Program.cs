// Exeptions: использование фильтра исключений

using System;

namespace Lesson_02.Exp_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 0;

            try
            {
                int result = x / y;
            }
            catch when (y == 0)
            {
                Console.WriteLine("y не должен быть равен 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}