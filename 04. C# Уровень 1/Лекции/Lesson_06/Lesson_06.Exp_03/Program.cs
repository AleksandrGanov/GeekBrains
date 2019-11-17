// FileStream. Копирование одного файла в другой посредством символьного потока

using System;
using System.IO;
using System.Text.RegularExpressions;
// Поиск всех чисел в файле
class Program
{
    static void Main()
    {
        StreamReader fileIn = new StreamReader("hobbit.txt");
        StreamWriter fileOut = new StreamWriter("numbers.txt", false);
        string text = fileIn.ReadToEnd();
        Regex r = new Regex(@"[-+]?\d+");
        Match integer = r.Match(text);
        while (integer.Success)
        {
            Console.WriteLine(integer);
            fileOut.WriteLine(integer);
            integer = integer.NextMatch();
        }
        fileIn.Close();
        fileOut.Close();
        Console.ReadKey();
    }
}
