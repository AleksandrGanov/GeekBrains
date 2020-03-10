// Создание очереди с использованием массива

using System;

using static mlConsole.PrintData;

using arrType = System.Char;

namespace Lesson05.Exp01
{
    class Program
    {
        static int N = -1, Nmax = 10;
        static arrType[] arrStack = new arrType[Nmax > 10 ? 10 : Nmax];

        static void Main()
        {
            Push('a');
            Push('b');
            Push('c');
            Push('d');
            Push('e');
            Push('f');
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