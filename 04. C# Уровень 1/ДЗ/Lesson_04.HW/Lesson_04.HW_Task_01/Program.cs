using System;
using mlConsole;

/* Описание задания:
Ганов Александр Анатольевич
====================
Дан целочисленный  массив  из 20 элементов. 
Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно.
Заполнить случайными числами.
Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
 */

namespace Lesson_04.HW_Task_01
{
    class Program
    {
        static void Main()
        {
            int arrLen = 50;
            int devider = 3;
            int max = 10000;
            int min = -10000;
            int[] arr = new int[arrLen];
            Random rnd = new Random();

            for (int i = 0; i < arrLen; i++) arr[i] = rnd.Next(min, max);
            PrintData.ArrPrint(arr,5);
            Console.WriteLine($"\nПары, в которых только одно число делится на: {devider}");
            SearchPair(arr, devider);
            Console.ReadLine();
        }
        static void SearchPair(int[] arr, int dev)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if ((arr[i - 1] % dev == 0 && arr[i] % dev != 0)
                    || (arr[i - 1] % dev != 0 && arr[i] % dev == 0))
                    Console.WriteLine($"|#{i,3}|{arr[i - 1],5}|{arr[i],5}|");
            }
        }
    }
}