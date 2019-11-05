using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Описание задания:
Ганов Александр Анатольевич
====================
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) *Сделать задание, только вывод организовать в центре экрана.
в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
 */

namespace Lesson_01.HW_Task_06
{
    class MyMethods
    {
        /// <summary>
        /// Вывод запроса пользователю через консоль и возврат результата ввода
        /// </summary>
        /// <param name="str">вопрос пользователю</param>
        /// <returns>ответ пользователя</returns>
        public static string AskUser(string str)
        {
            Console.Write(str + ": ");
            return Console.ReadLine();
        }
        /// <summary>
        /// Запрос значения "Int" через консоль с проверкой на тип значения
        /// </summary>
        /// <param name="msg">Сообщение, выдаваемое пользователю</param>
        /// <returns>Введенное в консоль значение</returns>
        static int GetValueInt(string msg)
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
        /// <summary>
        /// Запрос значения "Double" через консоль с проверкой на тип значения
        /// </summary>
        /// <param name="msg">Сообщение, выдаваемое пользователю</param>
        /// <returns>Введенное в консоль значение</returns>
        static double GetValueDouble(string msg)
        {
            double x; bool flag;
            do
            {
                Console.WriteLine(msg);
                flag = double.TryParse(Console.ReadLine(), out x);
            }
            while (!flag);  //  Пока false(!false=true), повторять цикл
            return x;
        }
        /// <summary>
        /// Вычисляет расстояние между точками с заданными координатами
        /// </summary>
        /// <param name="x1">абсцисса точки 1</param>
        /// <param name="y1">ордината точки 1</param>
        /// <param name="x2">абсцисса точки 2</param>
        /// <param name="y2">ордината точки 2</param>
        /// <returns>расстояние между точками</returns>
        static double CalcDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        /// <summary>
        /// Проверка выхода зоны печати за границы буфера окна консоли
        /// </summary>
        /// <param name="str">строка для вывода в консоль</param>
        /// <param name="x">начальная позиция курсора по горизонтали</param>
        /// <param name="y">начальная позиция курсора по вертикали</param>
        /// <returns>условие проверки: возможна печать да/нет</returns>
        public static bool CheckInitPostion(string str, int x, int y)
        {
            if (str.Length + x <= Console.BufferWidth &&
                y <= Console.BufferHeight - 1)
            {
                return true;
            }
            else
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.WriteLine("Максимальная нач.позиция по ширине: " + (Console.BufferWidth - str.Length) + ", по высоте: " + (Console.BufferHeight - 1) +
                    "\nВведите другие данные");
                return false;
            }
        }
        /// <summary>
        /// Проверка выхода зоны печати за границы буфера окна консоли
        /// </summary>
        /// <param name="arr">массив строк для вывода в консоль</param>
        /// <param name="x">начальная позиция курсора по горизонтали</param>
        /// <param name="y">начальная позиция курсора по вертикали</param>
        /// <returns>условие проверки: возможна печать да/нет</returns>
        public static bool CheckInitPostion(string[] arr, int x, int y)
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
                y + (arr.Length - 1) <= Console.BufferHeight - 1)
            {
                return true;
            }
            else
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.WriteLine("\nМаксимальная нач.позиция по ширине: " + (Console.BufferWidth - maxLength) +
                    ", по высоте: " + (Console.BufferHeight - arr.Length - 2) + "\nВведите другие данные");
                return false;
            }
        }
        /// <summary>
        /// Вывод строковой информации в консоль, печать возможно с любой позиции курсора
        /// в рамках буфера консоли
        /// </summary>
        /// <param name="str">строка для вывода в консоль</param>
        /// <param name="x">начальная позиция курсора по горизонтали</param>
        /// <param name="y">начальная позиция курсора по вертикали</param>
        public static void PrintMessage(string str, int x, int y)
        {
            if (str.Contains("\n"))
            {
                string[] arr = str.Split('\n');
                if (!CheckInitPostion(arr, x, y))
                {
                    return;
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.SetCursorPosition(x - arr[i].Length / 2, y);
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
    }
}
