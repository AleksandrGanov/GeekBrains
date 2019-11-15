using System;
using System.Text;

/*
 Задача 1. Вывести все слова сообщения, которые начинаются и заканчиваются на одну и ту же букву
 -----------------------------------------------------------------------------------------------------------------------------------
 Дана строка, в которой содержится осмысленное текстовое сообщение
 Слова сообщения разделяются пробелами и знаками препинания
 Вывести все слова сообщения, которые начинаются и заканчиваются на одну и ту же букву 
 */

namespace Lesson_05.Exp_14
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку: ");
            StringBuilder a = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Исходная строка: " + a);
            for (int i = 0; i < a.Length;) if (char.IsPunctuation(a[i])) a.Remove(i, 1);
                else ++i;
            string str = a.ToString();
            string[] s = str.Split(' ');
            Console.WriteLine("Искомые слова: ");
            for (int i = 0; i < s.Length; ++i)
                if (s[i][0] == s[i][s[i].Length - 1]) Console.WriteLine(s[i]);
            Console.ReadLine();
        }
    }
}