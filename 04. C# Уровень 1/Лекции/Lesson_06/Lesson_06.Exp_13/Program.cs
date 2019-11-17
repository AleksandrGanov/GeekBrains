/* Задача 4. Сканер
-----------------------------------------
Написать программу нахождения всех адресов почты в заданной папке
 */

using System;
using System.IO;
using System.Text.RegularExpressions;
// Пример сканирования папки D:\Temp на поиск всех адресов e-mail

namespace MailScan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получаем список файлов в папке. AllDirectories - сканировать также и подпапки
            string[] fs = Directory.GetFiles("D:\\temp", "*.*", SearchOption.AllDirectories);
            // Просматриваем каждый файл в массиве
            foreach (var filename in fs)
            {
                bool flag = false;
                // Создаем регулярное выражения дя поиска почтовых адресов
                Regex regex = new Regex(@"(\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,6})");
                try
                {
                    // Считываем файл
                    string s = File.ReadAllText(filename);
                    // Выводим найденные адреса на экран
                    foreach (var c in regex.Matches(s))
                    {
                        Console.Write("{0} ", c);
                        flag=true;
                    }
                    if (flag) Console.WriteLine($"<== {filename}");
                }
                catch (Exception)
                {
                    Console.WriteLine($"Не доступа к файлу {filename}, пропущен");
                }
            }
            Console.ReadLine();
        }
    }
}