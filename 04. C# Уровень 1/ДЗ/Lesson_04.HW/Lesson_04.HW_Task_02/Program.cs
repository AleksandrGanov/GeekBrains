using System;
using UserInteraction;

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

            arr = ArrHandle.FillRndArray(arr.Length, min, max);
            ConsolePrintData.ArrPrint(arr, 5);
            Console.WriteLine($"\n\nПары, в которых только одно число делится на: {devider}");
            ArrHandle.SearchPair(arr, devider);
            Console.WriteLine();

            Array.Clear(arr, 0, arrLen);
            arr = ArrHandle.FillRndArray(rnd.Next(1, arrLen / 2), min, max);
            ArrHandle.WriteFile(@"..\..\..\SampleData.txt", arr);
            ArrHandle.ReadFile(@"..\..\..\SampleData.txt");
            Console.ReadLine();
        }
    }
}
