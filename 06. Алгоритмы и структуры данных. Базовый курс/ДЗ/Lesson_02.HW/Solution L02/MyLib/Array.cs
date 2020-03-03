// Some Methods to work with Arrays

using mlConsole;
using System;
using System.Collections.Generic;
using System.IO;

namespace mlArray
{
    public static class ArrMaker
    {
        static readonly Random rnd = new Random();

        public static int[] IntRndArray(int n, int min, int max)
        {
            int[] arr = new int[n];    
            for (int i = 0; i < n; i++) arr[i] = rnd.Next(min,max);
            return arr;
        }

    }
    public class OneDimArray
    {
        readonly int[] a;

        /// <summary>
        /// ctor. Заполняет все элементы массива полученной величиной
        /// </summary>
        /// <param name="n">Количество элементов массива</param>
        /// <param name="el">Значение каждого элемента массива</param>
        /// 
        public OneDimArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        /// <summary>
        /// ctor. Заполняет массив прозвольными данными
        /// </summary>
        /// <param name="n">Количество элементов массива</param>
        /// <param name="min">Нижняя граница для генерации случайного числа</param>
        /// <param name="max">Верхняя граница для генерации случайного числа</param>
        /// 
        public OneDimArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        /// <summary>
        /// ctor. Заполняет массив данными начиная с "int" c шагом "step"
        /// </summary>
        /// <param name="n">Количество элементов массива</param>
        /// <param name="init">Начальное значение элементов массив</param>
        /// <param name="step">Приращение (шаг) увеличения элемента</param>
        public OneDimArray(int n, int init, byte step)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = init;
                init += step;
            }
        }
        /// <summary>
        /// Возвращает максимальное значение элементов массива из поля класса
        /// </summary>
        public int Max
        {
            get {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        /// <summary>
        /// Возвращает количество повторений элементов с максимальным значением из поля класса
        /// </summary>
        public int MaxCount
        {
            get {
                int max = Max;
                int counter = 0;
                foreach (int el in a) if (el == max) counter++;
                return counter;
            }
        }
        /// <summary>
        /// Возвращает минимальное значение элементов массива из поля класса
        /// </summary>
        public int Min
        {
            get {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        /// <summary>
        /// Возвращает сумму всех элементов массива из поля класса
        /// </summary>
        public int Sum
        {
            get {
                int sum = 0;
                foreach (int el in a) sum += el;
                return sum;
            }
        }
        /// <summary>
        /// Возвращает количество положительных элементов массива из поля класса
        /// </summary>
        public int CountPositiv
        {
            get {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        /// <summary>
        /// Возвращает количество повторение каждого элемента массива из поля класса
        /// </summary>
        /// <returns>Количество повторение каждого элемента массива из поля класса</returns>
        public Dictionary<int, int> EachElCount
        {
            get {
                SortedDictionary<int, int> dict = new SortedDictionary<int, int>();
                for (int i = 0; i < a.Length; i++)
                {
                    if (!dict.ContainsKey(a[i])) dict.Add(a[i], 1);
                    else
                    {
                        dict.TryGetValue(a[i], out int v);
                        dict.Remove(a[i]);
                        dict.Add(a[i], ++v);
                    }
                }
                // перегружаем сортированный словарь
                Dictionary<int, int> dict2 = new Dictionary<int, int>();
                foreach (int el in dict.Keys)
                {
                    dict.TryGetValue(el, out int v);
                    dict2.Add(el, v);
                }
                return dict2;
            }
        }

        /// <summary>
        /// Возвращает массив из поля класса (клон массива)
        /// </summary>
        /// <returns>Массив из поля класса</returns>
        public int[] GetArr()
        {
            int[] arr = (int[])a.Clone();
            return arr;
        }
        /// <summary>
        /// Возвращает инвертированный массив из поля класса (клон массива)
        /// </summary>
        /// <returns>Инвертированный массив из поля класса</returns>
        public int[] GetArrReversed()
        {
            int[] arr = (int[])a.Clone();
            System.Array.Reverse(arr);
            return arr;
        }
        /// <summary>
        /// Каждый элемент массива экземпляра умножается на заданный множитель
        /// </summary>
        /// <param name="mult">Множитель</param>
        public void Multi(int mult)
        {
            for (int i = 0; i < a.Length; i++) a[i] *= mult;
        }
        /// <summary>
        /// Вывод в строку значений всех элементов массива из поля класса (клон массива)
        /// </summary>
        /// <returns>Строка значений массива поля класс, значения разделены символом "|"</returns>
        public override string ToString()
        {
            int[] arr = (int[])a.Clone();
            string s = "|";
            foreach (int v in arr)
                s += v + "|";
            return s;
        }
    }
    public struct ArrFileIO
    {
        /// <summary>
        /// Метод записывает массив в файл добавлением к имеющимся данным
        /// </summary>
        /// <param name="path">Путь к целевому файлу</param>
        /// <param name="arr">Входящий массив для записи в файл</param>
        public static void AppendToFile(string path, int[] arr)
        {
            try
            {
                StreamReader sr = new StreamReader(path, true);
                string initStr = sr.ReadLine();
                sr.Close();
                StreamWriter sw = new StreamWriter(path, true);

                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == 0 && (initStr == null || initStr.Trim().Length == 0)) sw.Write($"{arr[i]}");
                    else sw.Write($"\n{arr[i]}"); ;
                }
                sw.Close();
                Console.WriteLine($"В файл \"{path.Replace("..\\", " ").Trim()}\" произведена запись массива");
                PrintData.ArrPrint(arr, 5);
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message} Запись в файл не произведена");
            }
        }
        /// <summary>
        /// Метод записывает массив в файл перезаписью имеющихся данных
        /// </summary>
        /// <param name="path">Путь к целевому файлу</param>
        /// <param name="arr">Входящий массив для записи в файл</param>
        public static void WriteToFile(string path, int[] arr)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path);
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == 0) sw.Write(arr[i]);
                    else sw.Write($"\n{arr[i]}");
                }
                sw.Close();
                Console.WriteLine($"В файл \"{path.Replace("..\\", " ").Trim()}\" произведена запись массива");
                PrintData.ArrPrint(arr, 5);
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message} Запись в файл не произведена");
            }
        }
        /// <summary>
        /// Метод считывает данные с целевого файла и возвращает их ввиде одномерного массива
        /// </summary>
        /// <param name="path">Путь к целевому файлу</param>
        /// <returns>Массив значений, считанных с целевого файла</returns>
        public static int[] ReadFromFile(string path)
        {
            int[] arr = new int[1];
            StreamReader sr = null;
            int j = 1; // счетчик элементов массивa
            bool flag = false;

            try
            {
                sr = new StreamReader(path);
                for (int i = 0; !sr.EndOfStream; i++)
                {
                    try
                    {
                        arr[j - 1] = int.Parse(sr.ReadLine());
                        if (!sr.EndOfStream) System.Array.Resize(ref arr, ++j);
                    }
                    catch
                    {
                        Console.WriteLine($"Ошибка: тип данных строки №{i + 1} не Int32, строка будет пропущена");
                        flag = true;
                    }
                }
                sr.Close();
                if (flag) Console.WriteLine();
                Console.WriteLine($"Считан файл: \"{path.Replace("..\\", " ").Trim()}\"");
                PrintData.ArrPrint(arr, 5);
                return arr;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message} Загрузка данных в массив не произведена");
                return null;
            }
        }
    }
}