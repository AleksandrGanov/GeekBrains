using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_02.HW_Task_01
{
    /// <summary>
    /// Базовый класс по учета работников
    /// </summary>
    public abstract class BaseWorker
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SalaryType { get; set; }
        public int Age { get; set; }
        public double MonthSalary { get; protected set; }

        public BaseWorker(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        
        /// <summary>
        /// Метод для расчета заработной платы работника
        /// </summary>
        /// <param name="salaryParam">Параметр расчета ЗП (часовая ставка для повременной 
        /// оплата, базовая ставка ЗП для фиксированной оплаты)</param>
        /// <returns>Возвращает расчетную заработную плату</returns>
        public abstract double SalaryCalculation(double salaryParam);
    }
}
