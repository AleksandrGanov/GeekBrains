// Интерфейсы #5

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
    void IExportLocally.Export()
    {
        Console.WriteLine("Локально");
    }
    void IExportToServer.Export()
    {
        Console.WriteLine("Сервер");
    }
}

internal class Program
{
    public static void Main()
    {
        // Вариант №1
        IExportLocally export = new ExportWord();
        IExportToServer export2 = new ExportWord();
        export.Export();
        export2.Export();

        //Вариант №2
        ExportWord exportExp2 = new ExportWord();
        ((IExportLocally)exportExp2).Export();
        ((IExportToServer)exportExp2).Export();

        Console.ReadLine();
    }
}