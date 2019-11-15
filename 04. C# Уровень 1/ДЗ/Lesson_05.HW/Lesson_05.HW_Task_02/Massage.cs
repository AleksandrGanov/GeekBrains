using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lesson_05.HW_Task_02
{
    static class Massage
    {
        /// <summary>
        /// Вывод только те слова, в которых количество букв больше заданных
        /// </summary>
        /// <param name="str">Входящий текст</param>
        /// <param name="letNum">Минимальная длина слова</param>
        public static void WordLettersMoreThan(string str, int letNum)
        {
            str = Regex.Replace(str, @"[\.!,:;?]", "");
            str = Regex.Replace(str, @"[\s]{2,}", " ");
            string[] words = str.Split(new char[] { ' ' });
            foreach (string el in words) if (el.Length > letNum) System.Console.WriteLine(el);
        }
        /// <summary>
        /// Удаляет из текста те слова, которые заканчиваются на определенный символ
        /// </summary>
        /// <param name="str">Входящий текст</param>
        /// <param name="letNum">Символ сравнения</param>
        public static void DeleteWordsEndingChar(string str, char ch)
        {
            string strToArr = Regex.Replace(str, @"[\.!,:;?]", "");
            strToArr = Regex.Replace(strToArr, @"[\s]{2,}", " ");
            string[] words = strToArr.Split(new char[] { ' ' });

            foreach (string el in words)
            {
                if (el.Length > 1 && el[el.Length - 1] == ch)
                {
                    str = str.Remove(str.IndexOf(el), el.Length);
                    System.Console.WriteLine($"Удалено: {el}");
                }
            }
            str = Regex.Replace(str, @"[\s]{2,}", " ");
            System.Console.WriteLine($"Оставшаяся строка: {str}");
        }
        /// <summary>
        /// Выводит в консоль самое длинное слово
        /// </summary>
        /// <param name="str">Входящий текст</param>
        public static void LongestWord(string str)
        {
            str = Regex.Replace(str, @"[\.!,:;?]", "");
            str = Regex.Replace(str, @"[\s]{2,}", " ");
            string[] words = str.Split(new char[] { ' ' });

            int lgstWordIndex = 0; // Индекс самого длинного слова массива
            if (words.Length != 0)
            {
                int len = words[0].Length;
                for (int i = 1; i < words.Length; i++)
                {
                    if (len < words[i].Length)
                    {
                        lgstWordIndex = i;
                        len = words[i].Length;
                    }
                }
            }
            System.Console.WriteLine($"Самое длинное слово: {words[lgstWordIndex]}");
        }
        /// <summary>
        /// Строит строку из самых длинных слов посредством класса StringBuilder
        /// </summary>
        /// <param name="str">Входящий текст</param>
        public static void StrBuilderLgstWord(string str)
        {
            str = Regex.Replace(str, @"[\.!,:;?]", "");
            str = Regex.Replace(str, @"[\s]{2,}", " ");
            string[] words = str.Split(new char[] { ' ' });
            StringBuilder strBld = new StringBuilder();

            int lgstWordIndex = 0; // Индекс самого длинного слова массива
            if (words.Length != 0)
            {
                int len = words[0].Length;
                for (int i = 1; i < words.Length; i++)
                {
                    if (len < words[i].Length)
                    {
                        lgstWordIndex = i;
                        len = words[i].Length;
                    }
                }

                strBld = strBld.Append("|");
                foreach (string word in words)
                {
                    if (word.Length == len) strBld = strBld.Append($"{word}|");
                }
            }
            System.Console.WriteLine($"Составленная фраза: {strBld.ToString()}");
        }
        /// <summary>
        /// Создает частотный Dictionary
        /// </summary>
        /// <param name="str">Входящий текст</param>
        public static Dictionary<string, int> FrequencyDictionary(string str)
        {
            str = Regex.Replace(str, @"[\.!,:;?]", "");
            str = Regex.Replace(str, @"[\s]{2,}", " ");
            string[] words = str.Split(new char[] { ' ' });

            SortedDictionary<string, int> dict = new SortedDictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (!dict.ContainsKey(words[i])) dict.Add(words[i], 1);
                else
                {
                    dict.TryGetValue(words[i], out int v);
                    dict.Remove(words[i]);
                    dict.Add(words[i], ++v);
                }
            }

            // перегружаем сортированный словарь
            Dictionary<string, int> dict2 = new Dictionary<string, int>();
            foreach (var el in dict.Keys)
            {
                dict.TryGetValue(el, out int v);
                dict2.Add(el, v);
            }
            return dict2;
        }
    }
}