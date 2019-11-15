using System;

// Символы char (работа с типом Array)

class Program
{
    static void PrintArray(string line, char[] a)
    {
        Console.WriteLine(line);
        foreach (char x in a) Console.Write(x);
        Console.WriteLine('\n');
    }

    static void Main()
    {
        char[] a = { 'm', 'a', 'Х', 'i', 'M', 'u', 'S', '!', '!', '!' };
        char[] b = "кол около колокола".ToCharArray(); // преобразование строки в массив символов
        PrintArray("Исходный массив а:", a);
        for (int x = 0; x < a.Length; x++)
            if (char.IsLower(a[x])) a[x] = char.ToUpper(a[x]);
        PrintArray("Измененный массив а:", a);
        PrintArray("Исходный массив b:", b);
        Array.Reverse(b);
        PrintArray("Измененный массив b:", b);
        Console.ReadLine();
    }
}

