/* 
Задача №1. Ганов Александр Анатольевич
----------------------------------------------------
Описание задания:
~~~~~~~~~~~~~
Создать программу, которая будет проверять корректность ввода логина.
Корректным логином будет строка:
-- от 2 до 10 символов
-- содержащая только буквы латинского алфавита или цифры
-- при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) с использованием регулярных выражений.
 */

using mlConsole;
using System;
using System.Text.RegularExpressions;

namespace Lesson_05.HW_Task_01
{
    class Program
    {
        static void Main()
        {
            int ans;
            bool ansContinue=false;
            bool flag;
            GetData gd;
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();

            do
            {
                Console.WriteLine($"\nКак будем проверять (выберите нужный вариант)?"
                    + "\n1. Штатной логикой"
                    + "\n2. С помощью регулярных выражений");
                ans = gd.GetValueInt("Выберите необходимое действие: ");
                Console.WriteLine();
                flag = false;

                switch (ans)
                {
                    case 1:
                        flag = CheckBaseLogic(login);
                        break;
                    case 2:
                        flag = CheckRegex(login);
                        break;
                    default:
                        Console.WriteLine($"Вариант с кодом \"{ans}\" отсутствует в программе");
                        ansContinue = gd.AnsYesNo("Желаете выполнить еще какие-либо действия? (y/n)");
                        break;
                }
            } while (ansContinue);

            if (flag) Console.WriteLine("Введенный логин прошел проверку, access granted");
            else Console.WriteLine("Введенный логин НЕ прошел проверку, access denied");
            Console.ReadLine();
        }

        private static bool CheckBaseLogic(string login)
        {
            bool _flag = login.Length >= 2 && login.Length <= 10;
            _flag = _flag && !Char.IsDigit(login[0]);
            
            foreach (char ch in login)
            {
                _flag = _flag && ((ch >= 'a' && ch <= 'z')
                                    || (ch >= 'A' && ch <= 'Z')
                                    || (ch >= '0' && ch <= '9'));
            }

            return _flag;
        }
        private static bool CheckRegex(string login)
        {
            Regex regex = new Regex(@"^[^0-9]{1}[a-zA-Z0-9]{1,9}$");
            return regex.IsMatch(login);
        }
    }
}