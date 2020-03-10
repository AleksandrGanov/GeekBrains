/* Описание задания:
Ганов Александр Анатольевич
====================
Написать программу, которая определяет, является ли введенная скобочная
последовательность правильной. Примеры правильных скобочных выражений: (), ([])(), {}(),
([{}]), неправильных — )(, ())({), (, ])}), ([(]) для скобок [, (, {.
Например: (2+(2*2)) или [2/{5*(4+7)}] 
*/

using System;

using arrType = System.Char;

namespace Lesson05.HW.Task02
{
    class Program
    {
        static Int32 N = -1;
        static readonly Int32 Nmax = 100;
        static readonly arrType[] arrStack = new arrType[Nmax];

        static void Main()
        {
            string str01 = @"(2+(2*2))";
            string str02 = @"(2/{5*(4+7}]";
            IsRightBraces(str01);
            ClearStack();
            IsRightBraces(str02);
            Console.ReadLine();
        }

        // Методы стека
        static void Push(arrType i)
        {
            if (N < Nmax)
            {
                N++;
                arrStack[N] = i;
            }
            else Console.WriteLine("Stack overflow");
        }
        static arrType? Pop(bool printOverFlow = false)
        {
            arrType defValue = default; // Дефолтное значение для типа стека 
            arrType? res = null; // Возвращаемое значение
            if (N != -1)
            {
                res = arrStack[N];
                arrStack[N] = defValue;
                N--;
            }
            else if (printOverFlow) Console.WriteLine("Stack overflow");
            return res;
        }
        static bool IfElementsExists()
        {
            if (N == -1) return false;
            else return true;
        }
        static void ClearStack() => Array.Clear(arrStack, 0, Nmax);

        // Метод проверки строки на верность скобок
        static void IsRightBraces(string str)
        {
            string mes = $"Строка со значение {str}";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' || str[i] == '[' || str[i] == '{') Push(str[i]);
                if (str[i] == ')' || str[i] == ']' || str[i] == '}')
                    if (Pop() == null)
                    {
                        Console.WriteLine($"{mes} не корректная");
                        return;
                    }
            }
            if (IfElementsExists())
            {
                Console.WriteLine($"{mes} не корректная");
                return;
            }
            else
            {
                Console.WriteLine($"{mes} корректная");
                return;
            }
        }
    }
}