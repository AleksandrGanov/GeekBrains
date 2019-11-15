/* 
Задача №2. Ганов Александр Анатольевич
----------------------------------------------------
Описание задания:
~~~~~~~~~~~~~
Модифицировать программу нахождения минимума функции так, чтобы можно было передавать 
    функцию в виде делегата.
а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции 
    и на каком отрезке находить минимум. Использовать массив (или список) делегатов, в котором хранятся 
    различные функции.
б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. 
    Пусть она возвращает минимум через параметр (с использованием модификатора out). 
 */

using mlConsole;
using System;
using f = Lesson_06.HW_Task_02.Functions;

namespace Lesson_06.HW_Task_02
{
    public delegate double Func(double x);

    class Program
    {
        static void Main()
        {
            GetData gd;
            Func[] arrFunc = new Func[]
            {
                f.F_Random,
                f.F_Sin,
                f.F_x3
            };
            int ans;

            Console.WriteLine($"Какую функцию использовать (выберите нужный вариант)?"
                + $"\n1. F_Random"
                + $"\n2. F_Sin"
                + $"\n3. F_x3");

            do
            {
                ans = gd.GetValueInt("Выберите необходимый номер: ");
                if (ans >= arrFunc.Length || ans <= 0)
                {
                    Console.WriteLine($"Функция с кодом \"{ans}\" отсутствует в программе");
                    ans = 0;
                }
            } while (ans == 0);
            double ansX = gd.GetValueDouble("Введите минимальное значение аргумента \"x\": ");
            double ansSegment;
            do
            {
                ansSegment = gd.GetValueDouble("Введите отрезок исследования функции: ");
                if (ansSegment <= ansX)
                {
                    Console.WriteLine($"Правый край интервал \"{ansSegment}\" не может быть меньше значения аргумента {ansX}");
                    ansSegment = 0;
                }
            } while (ansSegment == 0);

            f.SaveFunc(arrFunc[ans - 1], "data.bin", ansX, ansSegment, 0.5);
            Console.WriteLine($"Минимальное значение: {f.Load("data.bin", out double[] arr):F2}");
            mlConsole.PrintData.ArrPrint(arr, 8);
            Console.ReadLine();
        }
    }
}