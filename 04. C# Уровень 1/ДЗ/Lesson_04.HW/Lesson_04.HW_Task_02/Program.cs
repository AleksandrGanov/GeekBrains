using System;
using mlConsole;
using mlArray;

/* Описание задания:
Ганов Александр Анатольевич
====================
Реализуйте задачу 1 в виде статического класса StaticClass;
а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
в)**Добавьте обработку ситуации отсутствия файла на диске.
 */

namespace Lesson_04.HW_Task_02
{
    class Program
    {
        static void Main()
        {
            int arrLen = 50;
            int devider = 3;
            int min = -10000;
            int max = 10000;
            int[] arr = new int[arrLen];
            Random rnd = new Random();
            string str = @"..\..\..\SampleData.txt";
            
            arr = new OneDimArray(arr.Length, min, max).GetArr();
            PrintData.ArrPrint(arr, 5);
            Console.WriteLine($"\nПары, в которых только одно число делится на: {devider}");
            ArrHandle.SearchPair(arr, devider);
            Console.WriteLine();

            Array.Clear(arr, 0, arrLen);
            arr = new OneDimArray(rnd.Next(1, arrLen / 2), min, max).GetArr();
            FileOper.AppendToFile(str, arr);
            FileOper.ReadFromFile(str);
            Console.ReadLine();
        }

        private static void OneDimArray(Int32 length, Int32 min, Int32 max)
        {
            throw new NotImplementedException();
        }
    }
}