// Some Methods to work with Console

using System;
using System.Collections.Generic;
using System.Text;

namespace mlConsole
{
    public static class GetData
    {
        /// <summary>
        /// Реализует выдачу ответа "Да/Нет" на запрос пользователя
        /// </summary>
        /// <param name="question">Вопрос, выдаваемый пользователю</param>
        /// <returns>булево True/False</returns>
        public static bool AnsYesNo(string question)
        {
            string ans;
            ans = AskUser(question + "Y/N").ToLower();
            while (!(ans == "y" || ans == "n"))
            {
                ans = AskUser("Введите \"y\" или \"n\", другие ответы не допускаются").ToLower();
            }
            if (ans == "y") return true; else return false;
        }
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
        public static int GetDenominator(string str)
        {
            int den;
            do
            {
                den = GetValueInt(str);
                try
                {
                    if (den == 0) throw new Exception($"Знаменатель не может быть равен нулю, введите другое число");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            } while (den == 0);
            return den;
        }
        /// <summary>
        /// Запрос значения "Int" через консоль с проверкой на тип значения
        /// </summary>
        /// <param name="msg">Сообщение, выдаваемое пользователю</param>
        /// <returns>Введенное в консоль значение</returns>
        public static int GetValueInt(string msg)
        {
            int x; bool flag;
            do
            {
                Console.Write(msg);
                flag = int.TryParse(Console.ReadLine(), out x);
            }
            while (!flag);  //  Пока false(!false=true), повторять цикл
            return x;
        }
        /// <summary>
        /// Запрос значения "UInt" через консоль с проверкой на тип значения
        /// </summary>
        /// <param name="msg">Сообщение, выдаваемое пользователю</param>
        /// <returns>Введенное в консоль значение</returns>
        public static uint GetValueUInt(string msg)
        {
            uint x; bool flag;
            do
            {
                Console.Write(msg);
                flag = uint.TryParse(Console.ReadLine(), out x);
            }
            while (!flag);  //  Пока false(!false=true), повторять цикл
            return x;
        }
        /// <summary>
        /// Запрос значения "Double" через консоль с проверкой на тип значения
        /// </summary>
        /// <param name="msg">Сообщение, выдаваемое пользователю</param>
        /// <returns>Введенное в консоль значение</returns>
        public static double GetValueDouble(string msg)
        {
            double x; bool flag;
            do
            {
                Console.Write(msg);
                flag = double.TryParse(Console.ReadLine(), out x);
            }
            while (!flag);  //  Пока false(!false=true), повторять цикл
            return x;
        }
    }
    public static class PrintData
    {
        /// <summary>
        /// Выводит в консоль содержимое одномерного массива
        /// </summary>
        /// <param name="arr">массив, данные которого требуется вывести в консоль</param>
        /// <param name="rowLen">количество элементов, отображаемых в строке консоли</param>
        /// <param name="width">минимальная ширина в символах выводимого элемента</param>
        public static void ArrPrint<T>(T[] arr, int rowLen, int width = 5, bool printElementsNumber = true)
        {
            if (typeof(T).ToString() != "System.Int32" ||
                typeof(T).ToString() != "System.Double")
            {
                int len = 0;
                StringBuilder msg = new StringBuilder();

                if (printElementsNumber) Console.Write($"Элементы массива ({arr.Length} шт.)");
                foreach (var item in arr)
                {
                    if (String.Format("{0:F2}", item).Length > len)
                        len = String.Format("{0:F2}", item).Length;
                }
                if (len < width) len = width;
                for (int i = 0; i < arr.Length; i++)
                {
                    msg.Clear().ToString();
                    string elLen = msg.Append(' ', len - String.Format("{0:F2}", arr[i]).Length).ToString();
                    if (i % rowLen == 0) Console.Write("\n|");
                    Console.Write($"{elLen}{arr[i]:F2}|");
                }
                Console.WriteLine();
            }
            else Console.WriteLine("Данный метод поддерживает: Int32, Double массивы"); ;
        }
        /// <summary>
        /// Выводит в консоль содержимое одномерного массива
        /// </summary>
        /// <param name="arr">массив, данные которого требуется вывести в консоль</param>
        /// <param name="rowLen">количество элементов, отображаемых в строке консоли</param>
        /// <param name="width">минимальная ширина в символах выводимого элемента</param>
        public static void ArrPrint(string[] arr, int rowLen, int width = 5)
        {
            int len = 0;
            StringBuilder msg = new StringBuilder();

            Console.Write($"Элементы массива ({arr.Length} шт.)");
            foreach (var item in arr)
            {
                if (item.Length > len) len = item.Length;
            }
            if (len < width) len = width;
            for (int i = 0; i < arr.Length; i++)
            {
                msg.Clear().ToString();
                string elLen = msg.Append(' ', len - arr[i].Length).ToString();
                if (i % rowLen == 0) Console.Write("\n|");
                Console.Write($"{elLen}{arr[i]}|");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Выводит в консоль содержимое Dictionary (|ключ|значение|)
        /// </summary>
        /// <param name="Dict">Dictionary, данные которого требуется вывести в консоль</param>
        public static void DictPrint(Dictionary<int, int> dict)
        {
            string line = "-----";
            string headerKey = "Key";
            string headerValue = "Value";
            Console.WriteLine($"Элементы словаря ({dict.Count} шт.)");
            Console.WriteLine($"|{headerKey,5}|{headerValue,5}|");
            Console.WriteLine($"|{line,5}|{line,5}|");
            foreach (int el in dict.Keys)
            {
                dict.TryGetValue(el, out int v);
                Console.WriteLine($"|{el,5}|{v,5}|");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Выводит в консоль содержимое Dictionary (|ключ|значение|)
        /// </summary>
        /// <param name="Dict">Dictionary, данные которого требуется вывести в консоль</param>
        public static void DictPrint(Dictionary<string, int> dict)
        {
            string line = "-----";
            string headerKey = "Key";
            string headerValue = "Value";
            Console.WriteLine($"Элементы словаря ({dict.Count} шт.)");
            Console.WriteLine($"|{headerKey,20}|{headerValue,5}|");
            Console.WriteLine($"|{line,20}|{line,5}|");
            foreach (string el in dict.Keys)
            {
                dict.TryGetValue(el, out int v);
                Console.WriteLine($"|{el,20}|{v,5}|");
            }
            Console.WriteLine();
        }
    }
}