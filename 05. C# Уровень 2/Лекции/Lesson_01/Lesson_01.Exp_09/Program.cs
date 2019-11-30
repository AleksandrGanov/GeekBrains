// Значение null и Nullable-типы

using System;

namespace Lesson_01.Exp_09
{
    class Person
    {
        public Adress Adress;
    }

    class Adress
    {
        public string City;
    }

    class Program
    {
        private string GetCityInPast(Person person)
        {
            // До C# 6.0 
            string city = String.Empty;
            if (person != null)
            {
                if (person.Adress != null)
                {
                    city = person.Adress.City;
                }
            }
            return city;
        }

        private string GetCityInPresent(Person person)
        {
            return person?.Adress?.City ?? ""; // Начиная с C# 6.0
        }
    }
}