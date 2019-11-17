// Пример записи файла различными способами

using System;
using System.Diagnostics;
using System.IO;
namespace CopySamples
{
    class Program
    {
        static void Main(string[] args)
        {
            long kbyte = 1024;
            long mbyte = 1024 * kbyte;
            long gbyte = 1024 * mbyte;
            long size = mbyte;
            //Write FileStream
            //Write BinaryStream
            //Write StreamReader/StreamWriter
            //Write BufferedStream

            Console.WriteLine("FileStream. Milliseconds:{0}", FileStreamSample("D:\\temp\\bigdata0.bin", size));
            Console.WriteLine("BinaryStream. Milliseconds:{0}", BinaryStreamSample("D:\\temp\\bigdata1.bin", size));
            Console.WriteLine("StreamWriter. Milliseconds:{0}", StreamWriterSample("D:\\temp\\bigdata2.bin", size));
            Console.WriteLine("BufferedStream. Milliseconds:{0}", BufferedStreamSample("D:\\temp\\bigdata3.bin", size));

            Console.ReadLine();
        }

        static long FileStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            //FileStream fs = new FileStream("D:\\temp\\bigdata.bin", FileMode.CreateNew, FileAccess.Write);
            for (int i = 0; i < size; i++)
                fs.WriteByte(0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static long BinaryStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; i < size; i++)
                bw.Write((byte)0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static long StreamWriterSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < size; i++)
                sw.Write(0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static long BufferedStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            int countPart = 4;//количество частей
            int bufsize = (int)(size / countPart);
            byte[] buffer = new byte[size];
            BufferedStream bs = new BufferedStream(fs, bufsize);
            //bs.Write(buffer, 0, (int)size);//Error!
            for (int i = 0; i < countPart; i++)
                bs.Write(buffer, 0, (int)bufsize);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
    }
}