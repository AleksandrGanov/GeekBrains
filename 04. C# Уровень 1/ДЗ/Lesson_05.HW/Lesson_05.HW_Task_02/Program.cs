﻿/* 
Задача №2. Ганов Александр Анатольевич
----------------------------------------------------
Описание задания:
~~~~~~~~~~~~~
Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
а) Вывести только те слова сообщения,  которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения
д) *Создать метод, который производит частотный анализ текста. 
    В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает
    сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.
 */

using mlConsole;
using System;


namespace Lesson_05.HW_Task_02
{
    class Program
    {
        static void Main()
        {
            string str = "Особенности производительности Методы Split выделяют память для возвращаемого объекта массива и объект "
                            + "String для каждого элемента массива. Если приложению требуется оптимальная производительность или управление "
                            + "выделением памяти является критически важным в приложении, рассмотрите возможность использования метода IndexOf "
                            + "или IndexOfAny и, при необходимости, метода Compare для нахождение подстроки в строке";

            Massage.WordLettersMoreThan(str, 6); // Метод №1
            Console.WriteLine();
            Massage.DeleteWordsEndingChar(str, 'а'); // Метод №2
            Console.WriteLine();
            Massage.LongestWord(str); // Метод №3
            Console.WriteLine();
            Massage.StrBuilderLgstWord(str); // Метод №4
            Console.WriteLine();
            PrintData.DictPrint(Massage.FrequencyDictionary(str)); // Метод №
            Console.ReadLine();
        }
    }
}