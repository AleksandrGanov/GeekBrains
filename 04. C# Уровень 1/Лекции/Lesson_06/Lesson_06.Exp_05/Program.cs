// BinaryWriter, BinaryReader. Произвольный доступ к двоичному файлу

using System;
using System.IO;

class Program
{
    static void Main()
    {
        // изменение данных в двоичном потоке
        FileStream f = new FileStream("data.dat", FileMode.Open);
        BinaryWriter fOut = new BinaryWriter(f);
        long n = f.Length;             // определяем количество байт в байтовом потоке
        byte a;
        for (int i = 0; i < n; i += 2) // сдвиг на две позиции, т.к. тип int занимает 4 байта
        {
            fOut.Seek(i, SeekOrigin.Begin);
            fOut.Write((byte)0);
        }
        fOut.Close();
        // чтение данных из двоичного потока
        f = new FileStream("data.dat", FileMode.Open);
        BinaryReader fIn = new BinaryReader(f);
        n = f.Length  ;              // определяем количество чисел в двоичном потоке
        for (int i = 0; i < n; i++)
        {
            a = fIn.ReadByte();
            Console.Write(a.ToString("X2") + " "); // переводим в HEX-запись и выводим на консоль
        }
        fIn.Close();
        f.Close();
        Console.ReadLine();
    }
}