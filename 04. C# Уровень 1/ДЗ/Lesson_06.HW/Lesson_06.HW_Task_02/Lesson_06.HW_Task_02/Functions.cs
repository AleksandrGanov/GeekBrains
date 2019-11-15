using System;
using System.IO;

namespace Lesson_06.HW_Task_02
{
    struct Functions
    {
        public static double F_Random(double x)
        {
            Random rnd = new Random();
            return x * x - 50 * x + 10 * rnd.Next(1, 100);
        }

        public static double F_Sin(double x)
        {
            Random rnd = new Random();
            return x * x - 10 * rnd.Next(1, 100) * Math.Sin(x);
        }

        public static double F_x3(double x)
        {
            Random rnd = new Random();
            return Math.Pow(x, 3) - 15 * rnd.Next(1, 100);
        }

        public static double Load(string fileName, out double[] arr)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            arr = new double[0];
            Console.WriteLine($"\nДанные из файла: {fileName}");
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                Array.Resize(ref arr, i + 1);
                d = bw.ReadDouble();
                if (d < min) min = d;
                arr[i] = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

        public static void SaveFunc(Func F, string fileName, double x, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            int counter = 0;
            while (x <= b)
            {
                counter++;
                bw.Write(F(x));
                x += h;
            }
            bw.Close();
            fs.Close();
            Console.WriteLine($"\nВ файл записано: {counter} знач., расчетная функция {F.Method.Name}");
        }
    }
}
