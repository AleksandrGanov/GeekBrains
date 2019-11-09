using System;
using System.IO;
using mlConsole;

namespace Lesson_04.HW_Task_02
{
    static class ArrHandle
    {
        /// <summary>
        /// Метод ищет пары элементов массива, в которых только одно число делится на заданный делитель
        /// </summary>
        /// <param name="arr">Массив, в котором ищутся пары значений</param>
        /// <param name="dev">Делитель, на который делится из пары значений</param>
        public static void SearchPair(int[] arr, int dev)
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