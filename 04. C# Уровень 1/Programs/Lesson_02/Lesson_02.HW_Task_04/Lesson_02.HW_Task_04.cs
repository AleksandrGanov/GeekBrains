using System;

/* Описание задания:
Ганов Александр Анатольевич
====================
Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
    программа пропускает его дальше или не пропускает.
 С помощью цикла do while ограничить ввод пароля тремя попытками.
 */

namespace Lesson_02.HW_Task_04
{
    class Program
    {
        static void Main()
        {
            int counter = 3;

            while (counter > 0)
            {
                counter--;
                string login = AskUser("Введите логин: ");
                string pass = AskUser("Введите пароль: ");
                if (CheckPass(login, pass))
                {
                    Console.WriteLine("Данные приняты. Вы вошли в систему!");
                    break;
                }
                else
                {
                    if (counter > 0) Console.WriteLine("Неверные данные, поробуйте еще раз");
                    else Console.WriteLine("Попытки окончены, за Вами выехали");
                }
            }
            Console.ReadLine();
        }

        static bool CheckPass(string login, string pass)
        {
            if (login == "root" && pass == "GeekBrains")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string AskUser(string str)
        {
            Console.Write(str);
            return Console.ReadLine();
        }
    }
}
