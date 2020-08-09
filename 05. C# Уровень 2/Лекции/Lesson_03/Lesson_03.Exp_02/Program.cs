// Использование обобщений

using System.CodeDom;

namespace Lesson_03.Exp_02
{
    class Program
    {
        static void Main()
        {
            // Необобщенный вариант
            var animalNotGeneric = new Animals {Gender = "Male"};
            animalNotGeneric.Gender = Sex.Male;

            //Обобщенный вариант
            var animalGeneric = new Animals<Sex> { Gender = Sex.Male };
        }
    }

    public class Animals
    {
        public object Gender;
    }
    /// <summary>
    /// Обобщенный тип с ограничением только по значимым типам
    /// </summary>
    /// <typeparam name="T">значимый тип</typeparam>
    public class Animals<T> where T: struct
    {
        public T Gender=default;
    }
    public enum Sex
    {
        Male,
        Female,
        Undefined
    }
}