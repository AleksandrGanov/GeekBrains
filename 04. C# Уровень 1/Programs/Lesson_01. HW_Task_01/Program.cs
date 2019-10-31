using System;

/* Описание задания:
Ганов Александр Анатольевич
====================
Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
В результате вся информация выводится в одну строчку:
а) используя  склеивание;
б) используя форматированный вывод;
в) используя вывод со знаком $.
 */

namespace Lesson_01.HW_Task_01
{
    class Program
    {
        static void Main()
        {
            string name = AskUser("Введите Ваше имя");
            string surname = AskUser("Введите Вашу фамилию");
            int age = Convert.ToInt32(AskUser("Введите Ваш возраст"));
            int height = Convert.ToInt32(AskUser("Введите Ваш рост"));
            int weight = Convert.ToInt32(AskUser("Введите Ваш вес"));

            // вариант "а" - склеивание
            Console.WriteLine("\nАнкета, вар \"а\":" +
                "\n================" +
                "\nИмя: " + name +
                "\nФамилия: " + surname +
                "\nВозраст: " + age +
                "\nРост: " + height +
                "\nВес: " + weight +
                "\n================");

            // вариант "б" - форматированный вывод
            Console.WriteLine("\nАнкета, вар \"б\":\n================\nИмя: {0}\nФамилия: {1}" +
                "\nВозраст: {2}\nРост: {3}\nВес: {4}\n================",
                name, surname, age, height, weight);

            // вариант "в" - вывод со знаком $ (интерполяция строк)
            Console.WriteLine($"\nАнкета, вар \"в\":\n================\nИмя: {name}\nФамилия: {surname}" +
                $"\nВозраст: {age}\nРост: {height}\nВес: {weight}\n================");

            Console.WriteLine("\nокончание вывода");
            Console.ReadLine();
        }

        static string AskUser(string str)
        {
            Console.Write(str + ": ");
            return Console.ReadLine();
        }
    }
}
