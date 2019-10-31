using System;

/* Описание задания:
Ганов Александр Анатольевич
====================
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) *Сделать задание, только вывод организовать в центре экрана.
в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
 */

namespace Lesson_01.HW_Task_05
{
    class Program
    {
        static void Main()
        {
            string name = AskUser("Введите Ваше имя");
            string surname = AskUser("Введите Вашу фамилию");
            string city = AskUser("Введите Ваш город проживания");
            string str = $"\nАнкета, вар \"a\":\n================\nИмя: {name}\nФамилия: {surname}\nГород: {city}\n================";
            //string str = "проверка";

            // пункт "а"
            Console.WriteLine(str);

            // пункт "б" (центр консоли)
            int cX = Console.BufferWidth / 2;
            int cY = Console.CursorTop;
            PrintMessage(str,cX,cY);

            // пункт "в" (произвольное место вывода)
            PrintMessage(str, 40, 40);

            Console.ReadLine();
        }

        // методы
        static string AskUser(string str)
        {
            Console.Write(str + ": ");
            return Console.ReadLine();
        }
        static void PrintMessage(string str, int x, int y)
        {  
            if (str.Contains("\n"))
            {
                string [] arr = str.Split('\n');
                if (!CheckInitPostion(arr,x,y))
                {
                    return;
                }

                for (int i=0; i<arr.Length;i++)
                {
                    Console.SetCursorPosition(x-arr[i].Length/2, y);
                    Console.WriteLine(arr[i]);
                    y = Console.CursorTop;
                }
            }
            else
            {
                if (!CheckInitPostion(str, x, y))
                {
                    return;
                }
                Console.SetCursorPosition(x, y);
                Console.WriteLine(str);
            }
        }

        // перегружаемые методы (проверка выхода символов за границу буфера окна)
        static bool CheckInitPostion(string str,int x,int y)
        {
            if (str.Length + x <= Console.BufferWidth&&
                y<= Console.BufferHeight-1)
            {
                return true;
            }
            else
            {
                Console.SetCursorPosition(0,Console.CursorTop);
                Console.WriteLine("Максимальная нач.позиция по ширине: " + (Console.BufferWidth-str.Length) + ", по высоте: " + (Console.BufferHeight-1) +  
                    "\nВведите другие данные");
                return false;
            }
        }
        static bool CheckInitPostion(string [] arr, int x, int y)
        {
            int maxLength = 0;

            // находим длину самой длинной строки массива
            foreach (string i in arr)
            {
                if (i.Length > maxLength)
                {
                    maxLength = i.Length;
                }
            }
                          
            if (maxLength + x <= Console.BufferWidth &&
                y+(arr.Length-1) <= Console.BufferHeight - 1)
            {
                return true;
            }
            else
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.WriteLine("\nМаксимальная нач.позиция по ширине: " + (Console.BufferWidth - maxLength) +
                    ", по высоте: " + (Console.BufferHeight - arr.Length-2) + "\nВведите другие данные");
                return false;
            }
        }
    }
}
