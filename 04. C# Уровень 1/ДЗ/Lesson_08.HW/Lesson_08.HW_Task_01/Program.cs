/* 
Задача №1. Ганов Александр Анатольевич
----------------------------------------------------
Описание задания:
~~~~~~~~~~~~~
С помощью рефлексии выведите все свойства структуры DateTime
 */

using System;
using System.Reflection;

namespace Lesson_08.HW_Task_01
{
    class Program
    {
        static void Main()
        {
            DateTime dt=new DateTime();
            foreach (var item in dt.GetType().GetProperties()) Console.WriteLine(item.ToString());
            Console.ReadLine();
        }
    }
}