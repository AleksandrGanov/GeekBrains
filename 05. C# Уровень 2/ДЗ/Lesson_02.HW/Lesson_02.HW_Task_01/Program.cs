/* Описание задания:
Ганов Александр Анатольевич
====================
+ Построить три класса (базовый и 2 потомка), описывающих работников с почасовой оплатой (один из потомков)
    и фиксированной оплатой (второй потомок). 
+ Описать в базовом классе абстрактный метод для расчета среднемесячной заработной платы. 
    Для «повременщиков» формула для расчета такова: «среднемесячная заработная плата = 20.8 * 8 * почасовая ставка»; 
    Для работников с фиксированной оплатой: «среднемесячная заработная плата = фиксированная месячная оплата»;
+ Создать на базе абстрактного класса массив сотрудников и заполнить его;
+ * Реализовать интерфейсы для возможности сортировки массива, используя Array.Sort();
- * Создать класс, содержащий массив сотрудников, и реализовать возможность вывода данных с использованием foreach
 */

using System;

namespace Lesson_02.HW_Task_01
{
    class Program
    {
        static void Main()
        {
            #region Базовая логика
            int workerNum = 20;
            object[] arrWorker = new object[workerNum];
            Random rnd = new Random();

            Console.WriteLine("Массив до сортировки\n--------------------");
            for (int i = 0; i < arrWorker.Length; i++)
            {
                if (rnd.Next(1, 3) == 1)
                {
                    arrWorker[i] = new TimeSalaryWorker($"Name_{i}", $"Surname_{i}", rnd.Next(18, 50), rnd.Next(250, 500));
                    PrintAddedWorker(arrWorker[i]);
                }
                else
                {
                    arrWorker[i] = new FixedSalaryWorker($"Name_{i}", $"Surname_{i}", rnd.Next(18, 50), rnd.Next(30000, 55000));
                    PrintAddedWorker(arrWorker[i]);
                }
            }

            Console.WriteLine("\nМассив после сортировки\n-----------------------");
            Array.Sort(arrWorker);
            foreach (object worker in arrWorker)
            {
                PrintAddedWorker(worker);
            }

            Console.ReadLine(); 
            #endregion
        }

        /// <summary>
        /// Метод выводит в консоль характеристики (поля) работников
        /// </summary>
        /// <param name="worker">Экземляр класса FixedSalaryWorker, TimeSalaryWorker</param>
        static void PrintAddedWorker(object worker)
        {
            #region Вариант печати с кастом до конкретного типа
            //string type = worker.GetType().ToString();
            //if (type == "TimeSalaryWorker")
            //{
            //    Console.WriteLine($"Добавлен работник: {((TimeSalaryWorker)worker).Name} {((TimeSalaryWorker)worker).Surname}," +
            //        $"возраст {((TimeSalaryWorker)worker).Age}, ЗП {((TimeSalaryWorker)worker).MonthSalary:F0}, тип ЗП: {((TimeSalaryWorker)worker).SalaryType}");
            //}
            //else if (type == "FixedSalaryWorker")
            //{
            //    Console.WriteLine($"Добавлен работник: {((FixedSalaryWorker)worker).Name} {((FixedSalaryWorker)worker).Surname}," +
            //        $"возраст {((FixedSalaryWorker)worker).Age}, ЗП {((FixedSalaryWorker)worker).MonthSalary:F0}, тип ЗП: {((FixedSalaryWorker)worker).SalaryType}");
            //}
            //else { Console.WriteLine("Необрабатываемый тип"); }
            #endregion
            #region Вариант печати с кастом до базового типа
            if (worker is BaseWorker)
            {
                Console.WriteLine($"Добавлен работник: {((BaseWorker)worker).Name} {((BaseWorker)worker).Surname}," +
                    $"возраст {((BaseWorker)worker).Age}, ЗП {((BaseWorker)worker).MonthSalary:F0}, тип ЗП: {((BaseWorker)worker).SalaryType}");
            }
            else { Console.WriteLine("Необрабатываемый тип"); }
            #endregion
        }
    }
}