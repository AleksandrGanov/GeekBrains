using mlArray;
using System;
using mlConsole;

/* Описание задания:
Ганов Александр Анатольевич
====================
а) Дописать класс для работы с одномерным массивом:
    -- Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом
    -- Создать свойство Sum, которое возвращает сумму элементов массива
    -- Создать свойство MaxCount, возвращающее количество максимальных элементов
    -- Создать метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений)
    -- Создать метод Multi, умножающий каждый элемент массива на определённое число
б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
е) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>) 
 */

namespace Lesson_04.HW_Task_03
{
    class Program
    {
        static void Main()
        {
            //byte step = 2;
            OneDimArray arr = new OneDimArray(50, 1, 15);
            PrintData.ArrPrint(arr.GetArr(), 15);
            Console.WriteLine();
            PrintData.ArrPrint(arr.GetArrReversed(), 15);
            Console.WriteLine();
            arr.Multi(5);
            PrintData.ArrPrint(arr.GetArr(), 5);
            Console.WriteLine($"\n{arr.ToString()}");
            Console.WriteLine();
            PrintData.DictPrint(arr.EachElCount);
            Console.ReadLine();
        }
    }
}
