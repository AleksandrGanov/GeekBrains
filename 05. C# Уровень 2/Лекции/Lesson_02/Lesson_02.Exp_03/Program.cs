// Интерфейсы #3

using System;

internal interface IExport : IExample
{
    void Export();
    void Export(string path);
}
internal interface IExample
{
    void Test();
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

    public void Test()
    {
        throw new NotImplementedException();
    }
}