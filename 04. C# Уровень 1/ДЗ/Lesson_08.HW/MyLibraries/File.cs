using System;
using System.IO;

namespace mlFile
{
    public struct FileWrite
    {
        /// <summary>
        /// Метод записывает данные в файл добавлением к имеющимся данным
        /// </summary>
        /// <param name="path">Путь к целевому файлу</param>
        /// <param name="str">Произвольная строка для записи</param>
        /// <param name="echo">Выводить данные о записи каждой строки в консоль Да/Нет</param>
        public static void AppendToFile(string path, string str, bool echo = false)
        {
            try
            {
                StreamWriter sr = new StreamWriter(path, true);
                sr.WriteLine(str);
                sr.Close();
                if (echo) Console.WriteLine($"Произведена запись строки: \"{str.Substring(0, 15)}.........\"");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message} Запись в файл не произведена");
            }
        }
        /// <summary>
        /// Метод записывает данные в файл с заменой имеющихся данных
        /// </summary>
        /// <param name="path">Путь к целевому файлу</param>
        /// <param name="str">Произвольная строка для записи</param>
        /// <param name="echo">Выводить данные о записи каждой строки в консоль Да/Нет</param>
        public static void WriteToFile(string path, string str, bool echo = false)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(str);
                sw.Close();
                if (echo) Console.WriteLine($"Произведена запись строки: \"{str.Substring(0, 15)}.........\"");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message} Запись в файл не произведена");
            }
        }
    }
    public struct FileRead
    {
        /// <summary>
        /// Метод считываеn все строки или указанное количество строк из файла
        /// </summary>
        /// <param name="path">Путь к целевому файлу</param>
        /// <param name="echo">Выводить данные о чтении каждой строки в консоль Да/Нет</param>
        /// <returns>Массив со строками из файла (не содержит пустых строк). В случае, если в файле не было
        /// строк, которые можно заполнить в массив, массив заполняется одним значением "No Data"/// </returns>
        public static string[] ReadFileToArr(string path, int rows = 0, bool echo = false)
        {
            string[] arr = new string[0];
            int counter = 0;

            try
            {
                StreamReader sr = new StreamReader(path);

                if (rows == 0)
                {
                    while (!sr.EndOfStream)
                    {
                        counter++;
                        string str = sr.ReadLine();
                        if (echo) Console.WriteLine($"Произведено чтение строки: \"{str.Substring(0, 15)}.........\"");
                        if (counter > arr.Length) Array.Resize(ref arr, counter);
                        if (!string.IsNullOrEmpty(str)) arr[counter - 1] = str.Trim();
                    }
                }
                else
                {
                    for (int i = 0; i < rows; i++)
                    {
                        counter++;
                        string str = sr.ReadLine();
                        if (echo) Console.WriteLine($"Произведено чтение строки: \"{str.Substring(0, 15)}.........\"");
                        if (counter > arr.Length) Array.Resize(ref arr, counter);
                        arr[counter] = str.Trim();
                        if (!string.IsNullOrEmpty(str)) arr[counter - 1] = str.Trim();
                    }
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message} Чтение файла не произведено");
            }
            if (arr.Length == 0)
            {
                Array.Resize(ref arr, 1);
                arr[0] = "No data";
                return arr;
            }
            else return arr;
        }
    }
}