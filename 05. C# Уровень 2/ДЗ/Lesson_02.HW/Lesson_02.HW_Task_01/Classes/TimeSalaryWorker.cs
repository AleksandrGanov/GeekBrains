using System;

namespace Lesson_02.HW_Task_01
{
    /// <summary>
    /// Класс для учета работников с повременной оплатой труда
    /// </summary>
    public class TimeSalaryWorker : BaseWorker, IComparable
    {
        public int HourRate { get; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="_hourRate">базовая часовая ставка</param>
        public TimeSalaryWorker(string name, string surname, int age, int hourRate) : base(name, surname, age)
        {
            SalaryType = "HourRate Salary";
            HourRate = hourRate;
            MonthSalary = 20.8 * 8 * hourRate;
        }

        /// <summary>
        /// Метод для расчета заработной платы работника с повременной оплатой
        /// </summary>
        /// <param name="hourRate">Часовая ставка для повременной при повременной оплате труда</param>
        /// <returns>Возвращает заработную плату в месяц</returns>
        public override double SalaryCalculation(double hourRate)
        {
            MonthSalary = 20.8 * 8 * hourRate;
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