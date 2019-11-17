// DirectoryInfo.Вывод информации о каталоге

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        DirectoryInfo dir = new DirectoryInfo(@"D:\Temp");
        Console.WriteLine("***** " + dir.Name + " *****");
        Console.WriteLine("FullName: {0}", dir.FullName);
        Console.WriteLine("Name: {0}", dir.Name);
        Console.WriteLine("Parent: {0}", dir.Parent);
        Console.WriteLine("Creation: {0}", dir.CreationTime);
        Console.WriteLine("Attributes: {0}", dir.Attributes.ToString());
        Console.WriteLine("Root: {0}", dir.Root);
        Console.ReadLine();
    }
}