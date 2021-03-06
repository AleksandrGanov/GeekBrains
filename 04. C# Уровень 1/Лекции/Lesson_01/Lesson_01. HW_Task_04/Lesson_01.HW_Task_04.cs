﻿using System;

/* Описание задания:
Ганов Александр Анатольевич
====================
Написать программу обмена значениями двух переменных:
а) с использованием третьей переменной;
б) *без использования третьей переменной.
 */

namespace Lesson_01.HW_Task_04
{
    class Program
    {
        static void Main()
        {

            int var1 = Convert.ToInt32(AskUser("Введите значение №1"));
            int var2 = Convert.ToInt32(AskUser("Введите значение №2"));
            int[] arr = new[] { var1, var2 };

            // обмен через доп.переменную
            Console.WriteLine($"\nДо обмена {var1}, {var2}");
            int var3 = var1;
            var1 = var2;
            var2 = var3;
            Console.WriteLine($"После обмена {var1}, {var2}");

            // обмен без доп.переменной через сумму
            Console.WriteLine($"\nДо обмена {var1}, {var2}");
            var1 = var1 + var2;
            var2 = var1 - var2;
            var1 = var1 - var2;
            Console.WriteLine($"После обмена {var1}, {var2}");

            // обмен без доп.переменной через XOR (побитовое сравнение)
            Console.WriteLine($"\nДо обмена {var1}, {var2}");
            var1 ^= var2;
            var2 ^= var1;
            var1 ^= var2;
            Console.WriteLine($"После обмена {var1}, {var2}");
            
            // обмен без доп.переменной через массив
            Console.WriteLine($"\nДо обмена {arr[0]}, {arr[1]}");
            Array.Reverse(arr);
            Console.WriteLine($"После обмена {arr[0]}, {arr[1]}");
            
            Console.ReadLine();
        }

        static string AskUser(string str)
        {
            Console.Write(str + ": ");
            return Console.ReadLine();
        }
    }
}
