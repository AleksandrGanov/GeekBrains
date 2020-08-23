/* Описание задания:
Ганов Александр Анатольевич
====================
Реализовать перевод из десятичной в двоичную систему счисления с использованием стека
 */

using System;

using static mlConsole.GetData;

using arrType = System.Int32;

namespace Lesson05.HW.Task01
{
    class Program
    {
        static int N = -1, Nmax = 10;
        static arrType[] arrStack = new arrType[Nmax > 10 ? 10 : Nmax];

        static void Main()
        {
            int value = (int)GetValueUInt("Введите положительное значение: ");
            while (value > 0)
            {
                int remainder = value % 2;
                value /= 2;
                Push(remainder);
            }
            while (N != -1) Console.Write($"{Pop()}");
            Console.ReadLine();
        }
        static void Push(arrType i)
        {
            if (N < Nmax)
            {
                N++;
                arrStack[N] = i;
            }
            else Console.WriteLine("Stack overflow");
        }
        static arrType? Pop()
        {
            arrType defValue = default; // Дефолтное значение для типа стека 
            arrType? res = null; // Возвращаемое значение
            if (N != -1)
            {
                res = arrStack[N];
                arrStack[N] = defValue;
                N--;
            }
            else Console.WriteLine("Stack overflow");
            return res;
        }
    }
}