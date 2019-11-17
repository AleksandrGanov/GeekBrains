/* Задача 3. Минимум функции
-----------------------------------------
Написать программу сохранения результатов вычисления заданной функции в файл для дальнейшей обработки файла
Разбить программу на две функции: одна записывает данные функции в файла на промежутке от a до b с шагом h,
    а другая считывает данные и находит минимум функции
 */

using System;
using System.IO;
namespace DoubleBinary
{
    class Program
    {
        public static double F(double x)
        {
            Random rnd = new Random();
            return x * x - 50 * x + 10*rnd.Next(1,100);
        }

        public static void SaveFunc(string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }

        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

        static void Main(string[] args)
        {
            SaveFunc("data.bin", -100, 100, 0.5);
            Console.WriteLine(Load("data.bin"));
            Console.ReadLine();
        }
    }
}