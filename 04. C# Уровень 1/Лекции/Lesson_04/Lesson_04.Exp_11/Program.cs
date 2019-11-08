using System;
using System.IO;

// Обработка исключений при работе с файлами

namespace ReadFromFileWithException
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"..\..\SampleData.txt");
            int sum = 0, count = 0;
            while (!sr.EndOfStream)  // Пока не конец потока (файла)
            {
                string s = sr.ReadLine();
                Console.WriteLine("Считали строку:" + s);
                try
                {
                    int a = int.Parse(s);
                    sum += a;
                    count++;
                    Console.WriteLine("{0}.Преобразовали в число:{1}", count, a);
                }
                // В экземпляре exc класса Exception будет храниться информация об ошибке
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
            sr.Close();
            // Обратите внимание! Если не поставить явное преобразование типов перед sum, 
            // sum/count получит целое число. Попробуйте убрать (double) перед sum
            string msg = $"Среднее арифметическое: {(double)sum / count:F2}";
            Console.WriteLine(msg.Replace(',','.'));
            Console.ReadLine();
        }
    }
}
