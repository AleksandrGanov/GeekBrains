/*
Задача 6. Заявление на отпуск
----------------------------------------
Написать программу создания заявления по шаблону. 
Разработать простой шаблон документа, куда вместо меняющегося текста вставить теги
Разработать программу, которая вместо тегов подставляет пользовательские данные.
 */

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Lesson_05.Exp_19
{
    struct Element
    {
        public string tag;
        public string str;
        public Element(string tag, string newString)
        {
            this.tag = tag;
            str = newString;
        }
    }

    class Program
    {
        static void Main()
        {
            string s = File.ReadAllText(@"..\..\shablon.txt");
            Element[] e = new Element[8]
            {
                new Element("name1","ООО 'Дружба'"),
                new Element("name2","Иванову И.И."),
                new Element("name3","менеджера по продажам"),
                new Element("name4","Сидорова А.А."),
                new Element("name5","Сидоров А.А."),
                new Element("data1","01.06.16"),
                new Element("data2","14.06.16"),
                new Element("data3","20.04.16"),
            };
            foreach (var el in e)
            {
                Regex reg = new Regex("<" + el.tag + ">");
                s = reg.Replace(s, el.str);
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}