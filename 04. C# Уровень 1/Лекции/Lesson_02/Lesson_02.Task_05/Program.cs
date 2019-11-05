using System;

// перечисления

namespace Lesson_02.Exp_05
{
    class Program
    {
        enum Months { None, January, February, March, April, May, June, July, August, September, October, November, December };
        enum Seasons { None, Winter, Spring, Summer, Autumn };

        static void Main(string[] args)
        {
            Months month = Months.January;
            Seasons season = Seasons.None;
            switch (month)
            {
                case Months.January:
                case Months.February:
                case Months.December:
                    season = Seasons.Winter;
                    break;
                case Months.March:
                case Months.April:
                case Months.May:
                    season = Seasons.Spring;
                    break;
                case Months.June:
                case Months.July:
                case Months.August:
                    season = Seasons.Summer;
                    break;
                case Months.September:
                case Months.October:
                case Months.November:
                    season = Seasons.Autumn;
                    break;
            }
            Console.WriteLine(season);
        }
    }
}
