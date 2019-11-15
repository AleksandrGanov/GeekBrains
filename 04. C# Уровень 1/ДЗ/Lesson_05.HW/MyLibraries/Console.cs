using System;
using System.Collections.Generic;

namespace mlConsole
{
    public struct GetData
    {
        /// <summary>
        /// Реализует выдачу ответа "Да/Нет" на запрос пользователя
        /// </summary>
        /// <param name="question">Вопрос, выдаваемый пользователю</param>
        /// <returns>булево True/False</returns>
        public bool AnsYesNo(string question)
        {
            string ans;
            ans = AskUser(question).ToLower();
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
        public string AskUser(string str)
        {
            Console.Write(str + ": ");
            return Console.ReadLine();
        }
        public int GetDenominator(string str)
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
        public int GetValueInt(string msg)
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
        /// Запрос значения "Double" через консоль с проверкой на тип значения
        /// </summary>
        /// <param name="msg">Сообщение, выдаваемое пользователю</param>
        /// <returns>Введенное в консоль значение</returns>
        public double GetValueDouble(string msg)
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
    public struct PrintData
    {
        /// <summary>
        /// Выводит в консоль содержимое одномерного массива
        /// </summary>
        /// <param name="arr">массив, данные которого требуется вывести в консоль</param>
        /// <param name="rowLen">количество элементов, отображаемых в строке консоли</param>
        static public void ArrPrint(int[] arr, int rowLen)
        {
            Console.Write($"Элементы массива ({arr.Length} шт.)");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % rowLen == 0) Console.Write("\n|");
                Console.Write($"{arr[i],5}|");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Выводит в консоль содержимое Dictionary (|ключ|значение|)
        /// </summary>
        /// <param name="Dict">Dictionary, данные которого требуется вывести в консоль</param>
        static public void DictPrint(Dictionary<int, int> dict)
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
        static public void DictPrint(Dictionary<string, int> dict)
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