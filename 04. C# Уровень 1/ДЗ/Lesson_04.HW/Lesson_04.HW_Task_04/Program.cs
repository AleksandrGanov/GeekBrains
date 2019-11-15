using mlConsole;
using mlFile;
using System;

namespace Lesson_04.HW_Task_04
{
    class Program
    {
        static void Main()
        {
            string path = @"..\..\..\FileToRead.txt";
            string[] arr = FileRead.ReadFileToArr(path);
            PrintData.ArrPrint(arr,50);
            Console.ReadLine();
        }
    }
}
