/* Описание задания:
Ганов Александр Анатольевич
====================
Написать программу обмена значениями двух целочисленных переменных:
a. с использованием третьей переменной;
b. *без использования третьей переменной
*/

using System;

using static mlConsole.GetData;

namespace Lesson01.HW.Task03
{
    class Program
    {
        static void Main()
        {
            int dig1 = GetValueInt("Введите число #1: ");
            int dig2 = GetValueInt("Введите число #2: ");
            
            Console.WriteLine($"Числа до обмена: {dig1}, {dig2}");
            ExchangeWithVariable(ref dig1, ref dig2);
            Console.WriteLine($"Обмен с доп.переменной: {dig1}, {dig2}");
            ExchangeWithoutVariable(ref dig1, ref dig2);
            Console.WriteLine($"Обмен без доп.переменной: {dig1}, {dig2}");
            Console.ReadLine();
        }
        static void ExchangeWithVariable(ref int dig1, ref int dig2)
        {
            int dig3=dig1;
            dig1 = dig2;
            dig2 = dig3;
        }
        static void ExchangeWithoutVariable(ref int dig1, ref int dig2)
        {
            dig1 += dig2;
            dig2 = dig1 - dig2;
            dig1 -= dig2;
        }
    }
}