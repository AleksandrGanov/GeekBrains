/* Задача 1. Последовательность Фибоначчи
----------------------------------------
Создать файл и записать в него n первых членов последовательности Фибоначчи
Вывести на экран все компоненты файла с порядковым номером, кратным 3
 */

using System;
using System.IO;

namespace FibonachiSeries
{
    class Program
    {
        static void Save(string fileName, int n)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            
            uint a0 = 0; // uint - занимает 4 байта
            uint a1 = 1;
            uint a;

            bw.Write(a0);
            bw.Write(a1);
            
            for (int i = 2; i < n; i++)
            {
                a = a0 + a1;
                bw.Write(a);
                a0 = a1;
                a1 = a;
            }
            fs.Close();
            bw.Close();
        }

        static void Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            for (int i = 1; i <= fs.Length / 4; i++) // uint занимает 4 байта
            {
                uint a = br.ReadUInt32();
                if (i % 3 == 0) Console.WriteLine("{0,3} {1}", i, a);
            }
            br.Close();
            fs.Close();
        }

        static void Main(string[] args)
        {
            Save("data.bin", 33);
            Load("data.bin");
            Console.ReadLine();
        }
    }
}