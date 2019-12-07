// Exeptions: генерация собственных исключений #2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_02.Exp_21
{
    class RobotException : Exception
    {
        public RobotException(string message)
            : base(message)
        {
        }
    }
    
    class Robot
    {
        const int MAX_HEIGHT = 100, MAX_WIDTH = 100;
        int height, width;

        public Robot(int высота, int ширина)
        {
            try
            {
                if (высота > MAX_HEIGHT) throw new RobotException("Превышена максимальная высота");
                if (ширина > MAX_WIDTH) throw new RobotException("Превышена максимальная ширина");
                height = ширина;
                width = высота;
                Console.WriteLine("Робот построен");
            }
            catch (RobotException e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Robot rbt_01 = new Robot(50,50);
            Robot rbt_02 = new Robot(150, 50);
            Robot rbt_03 = new Robot(50, 150);
            Console.ReadLine();
        }
    }
}
