// 1. Пример №2. GetType, typeof

using System;
using System.Reflection;
class Program
{
    static PropertyInfo GetPropertyInfo(object obj, string str)
    {
        return obj.GetType().GetProperty(str);
    }

    static void Main(string[] args)
    {
        DateTime dateTime = new DateTime();
        Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").CanRead);
        Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").CanWrite);
        Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").GetValue(dateTime, null));
        Console.ReadKey();
    }
}