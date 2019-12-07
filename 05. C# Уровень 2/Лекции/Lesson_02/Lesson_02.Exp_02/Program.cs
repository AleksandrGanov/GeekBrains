// Интерфейсы #2

using System;
using mlConsole;

internal interface IExport
{
    void Export();
    void Export(string path);
}

internal class ExportWord : IExport
{
    public void Export()
    {
        throw new NotImplementedException();
    }
    public void Export(string path)
    {
        throw new NotImplementedException();
    }
}

internal class ExportExcel : IExport
{
    public void Export()
    {
        throw new NotImplementedException();
    }
    public void Export(string path)
    {
        throw new NotImplementedException();
    }
}

internal class Program
{
    public static void Main()
    {
        IExport export;
        GetData gd;
        bool ans = gd.AnsYesNo("Экспорт в Word, y/n?");

        if (!ans) // Теперь мы можем по условию создать нужный нам объект
        {
            export = new ExportExcel();
            Console.WriteLine("Excel");
        }
        else
        {
            export = new ExportWord();
            Console.WriteLine("Word");
        }
        Console.ReadLine();
    }
}