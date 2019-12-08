using System;
using System.Collections;

namespace Lesson_02.HW_Task_01
{
    /// <summary>
    /// Класс для учета работников с фиксированной ЗП
    /// </summary>
    public class FixedSalaryWorker : BaseWorker, IComparable
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="_monthSalary">Заработная плата в месяц</param>
        public FixedSalaryWorker(string name, string surname, int age, double monthSalary): base(name, surname, age)
        {
            SalaryType = "Fixed Salary";
            MonthSalary = monthSalary;
        }

        /// <summary>
        /// Метод для расчета заработной платы работника с фиксированной оплатой труда
        /// </summary>
        /// <param name="hourRate">Заработная плата в месяц</param>
        /// <returns>Возвращает заработную плату в месяц</returns>
        public override double SalaryCalculation(double monthSalary)
        {
            MonthSalary = monthSalary;
            return MonthSalary;
        }
        
        /// <summary>
        /// Реализация интерфейса IComparable (сортировка по ЗП)
        /// </summary>
        /// <param name="obj">Объект для сравнения</param>
        /// <returns>Возвращает результат сравнения объектов: 1, -1, 0</returns>
        public int CompareTo(object obj)
        {
            if (MonthSalary < ((BaseWorker)obj).MonthSalary) return 1;
            if (MonthSalary > ((BaseWorker)obj).MonthSalary) return -1;
            return 0;
        }
    }
}