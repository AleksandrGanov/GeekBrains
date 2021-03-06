﻿// Неизменямые строки System.String (способы создания)

namespace Lesson_05.Exp_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // инициализация отложена
            string s1;

            // инициализация строковым литералом
            string s2 = "Колпак на колпаке, под колпаком колпак";

            // символ @ сообщает конструктору string, что строку
            // нужно воспринимать буквально, даже если она занимает несколько строк
            string s3 = @"http://
                            geekbrains.ru";

            // конструктор создает строку из 20 пробелов
            string s4 = new string(' ', 20);

            // инициализировали целочисленную переменную
            int x = 12344556;

            // преобразовали ее к типу string
            string s5 = x.ToString();

            // создали массив символов
            char[] a = { 'a', 'b', 'c', 'd', 'e' };

            // создание строки из массива символов
            string v = new string(a);

            // создание строки из части массива символов, при этом: 0
            // показывает с какого символа, 2 – сколько символов использовать для инициализации
            char[] a2 = { 'a', 'b', 'c', 'd', 'e' };
            string v2 = new string(a, 0, 2);
        }
    }
}
