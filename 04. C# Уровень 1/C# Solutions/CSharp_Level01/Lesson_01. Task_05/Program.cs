using System;

// Работа с консолью и перегрузкой методов

namespace Lesson_01.Task_05
{
    class Program
    {
        static void Print(string msg, int x, int y)
        {
            // Установим позицию курсора на экране
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
        static void Print(string msg, ConsoleColor foregroundcolor)
        {
            // Установим цвет символов
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(msg);
        }

        static void Main()
        {
            Print("Привет!\n", 10, 10);
            Print("Привет еще раз!", ConsoleColor.Red);
            Console.ReadLine();
        }

    }
}
