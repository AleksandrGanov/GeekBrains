using System;

// Неизменямые строки System.String (использование свойств и методов)

namespace Lesson_05.Exp_04
{
    class Program
    {
        static void Main()
        {
            string str1 = "Первая строка";
            string str2 = string.Copy(str1);
            string str3 = "Вторая строка";
            string str4 = "ВТОРАЯ строка";
            string strUp, strLow;
            int result, idx;
            Console.WriteLine("str1: " + str1);
            Console.WriteLine("Длина строки str1: " + str1.Length);

            // создаем прописную и строчную версии строки str1.
            strLow = str1.ToLower();
            strUp = str1.ToUpper();
            Console.WriteLine("Строчная версия строки str1: " + strLow);
            Console.WriteLine("Прописная версия строки str1: " + strUp);
            Console.WriteLine();

            // сравниваем строки
            result = str1.CompareTo(str3);
            if (result == 0) Console.WriteLine("str1 и str3 равны.");
            else if (result < 0) Console.WriteLine("str1 меньше, чем str3");
            else Console.WriteLine("str1 больше, чем str3");
            Console.WriteLine();

            // сравниваем строки без учета регистрай
            result = String.Compare(str3, str4, true);
            if (result == 0) Console.WriteLine("str3 и str4 равны без учета регистра.");
            else Console.WriteLine("str3 и str4 не равны без учета регистра.");
            Console.WriteLine();

            // сравниваем части строк
            result = String.Compare(str1, 4, str2, 4, 2);
            if (result == 0) Console.WriteLine("часть str1 и str2 равны");
            else Console.WriteLine("часть str1 и str2 не равны");
            Console.WriteLine();

            // поиск строк
            idx = str2.IndexOf("строка");
            Console.WriteLine("Индекс первого вхождения подстроки строки: " + idx);
            idx = str2.LastIndexOf("о");
            Console.WriteLine("Индекс последнего вхождения символа о: " + idx);

            // конкатенация
            string str = String.Concat(str1, str2, str3, str4);
            Console.WriteLine(str);

            // удаление подстроки
            str = str.Remove(0, str1.Length);
            Console.WriteLine(str);

            // замена подстроки "строка" на пустую подстроку
            str = str.Replace("строка", "");
            Console.WriteLine(str);
        }
    }
}
