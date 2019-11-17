// FileStream. Копирование одного файла в другой

using System;
using System.IO;// для работы с потоками ввода-вывода

class Program
{
    static void Main()
    {
        byte[] b=new byte [0];

        int counter=0;
        try
        {
            FileStream fileIn = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
            FileStream fileOut = new FileStream("newData.txt", FileMode.Create, FileAccess.Write);
           
            int i;
            while ((i = fileIn.ReadByte()) != -1)
            {
                counter++;
                Array.Resize(ref b, counter);
                b[counter-1] = (byte)i;
                fileOut.WriteByte((byte)i);
            }
            fileIn.Close();
            fileOut.Close();
        }
        catch (Exception exc)
        {
            Console.WriteLine(exc.Message);
        }
        Console.WriteLine(System.Text.Encoding.GetEncoding("utf-8").GetString(b));
        Console.WriteLine($"Файл успешно скопирован"); 
        Console.Read();
    }
}