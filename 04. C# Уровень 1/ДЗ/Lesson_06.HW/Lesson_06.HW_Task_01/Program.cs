/* 
Задача №1. Ганов Александр Анатольевич
----------------------------------------------------
Описание задания:
~~~~~~~~~~~~~
Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
 */

using System;
using f = Lesson_06.HW_Task_01.Functions;

namespace Lesson_06.HW_Task_01
{
    public delegate double Fun(double x, double y);

    class Program
    {
        static void Main()
        {
            f.Table(f.MyFunc, -2, 2, -3, 5);
            f.Table(f.MyFuncSin, -2, 2, -3, 5);
            Console.ReadLine();
        }
    }
}