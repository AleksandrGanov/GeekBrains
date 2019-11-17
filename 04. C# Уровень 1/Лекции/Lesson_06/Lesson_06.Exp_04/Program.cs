// BinaryReader. Пример формирования двоичного файла посредством двоичного потока

using System;
using System.IO;

class Program
{
    static void Main()
    {
        FileStream f = new FileStream("data.bin", FileMode.Open);
        BinaryReader fIn = new BinaryReader(f);
        long n = f.Length / 4; // определяем количество чисел в двоичном потоке
        int a;
        for (int i = 0; i < n; i++)
        {
            a = fIn.ReadByte();
            Console.Write(a + " ");
        }
        fIn.Close();
        f.Close();
        Console.ReadLine();
    }
}