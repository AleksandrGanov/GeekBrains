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
                StreamWriter sr = new StreamWriter(path);
                sr.WriteLine(str);
                sr.Close();
                if (echo) Console.WriteLine($"Произведена запись строки: \"{str.Substring(0, 15)}.........\"");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message} Запись в файл не произведена");
            }
        }
    }
    // todo: public struct FileRead { }
}
