// Интерфейсы #4


using System;

internal interface IExportLocally
{
    void Export();
}

internal interface IExportToServer
{
    void Export();
}

internal class ExportWord : IExportLocally, IExportToServer
{
    public void Export()
    {
        Console.WriteLine("Экспорт");
    }
}

internal class Program
{
    public static void Main()
    {
        IExportLocally export = new ExportWord();
        IExportToServer export2 = new ExportWord();
        export.Export();
        export2.Export();
        Console.ReadLine();
    }
}