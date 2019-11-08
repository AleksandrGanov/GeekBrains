using System;
using System.IO;
using UserInteraction;

namespace Lesson_04.HW_Task_02
{
    static class ArrHandle
    {
        public static int[] FillRndArray(int arrLen, int min, int max)
        {
            Random rnd = new Random();
            int[] arr = new int[arrLen];
            for (int i = 0; i < arr.Length; i++) arr[i] = rnd.Next(min, max);
            return arr;
        }
        public static void SearchPair(int[] arr, int dev)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if ((arr[i - 1] % dev == 0 && arr[i] % dev != 0)
                    || (arr[i - 1] % dev != 0 && arr[i] % dev == 0))
                    Console.WriteLine($"|#{i,3}|{arr[i - 1],5}|{arr[i],5}|");
            }
        }
        public static int[] ReadFile(string path)
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
                        if (!sr.EndOfStream) Array.Resize(ref arr, ++j);
                    }
                    catch
                    {
                        Console.WriteLine($"Ошибка: тип данных строки №{i + 1} не Int32, строка будет пропущена");
                        flag = true;
                    }
                }
                sr.Close();
                if (flag) Console.WriteLine();
                Console.WriteLine($"Считан файл: \"{path}\"");
                ConsolePrintData.ArrPrint(arr, 5);
                return arr;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message} Загрузка данных в массив не произведена");
                return null;
            }
        }
        public static void WriteFile(string path, int[] arr)
        {
            try
            {
                StreamWriter sr = new StreamWriter(path);
                sr.Flush();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == 0) sr.Write(arr[i]);
                    else sr.Write($"\n{arr[i]}");
                }
                sr.Close();
                Console.WriteLine($"В файл \"{path}\" произведена запись массива");
                ConsolePrintData.ArrPrint(arr, 5);
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message} Запись в файл не произведена");
            }
        }
    }
}
