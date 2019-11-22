// Пример №1. GetType, typeof

using System;

class Program
{
    static void Main()
    {
        Type type = typeof(int);
        Console.WriteLine(type);

        int i = 0;
        Type type2 = i.GetType();
        Console.WriteLine(type2);
    }
}