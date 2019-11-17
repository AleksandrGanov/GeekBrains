/* Задача 2. Сложная задача ЕГЭ
-------------------------------------------
Для заданной последовательности неотрицательных целых чисел необходимо найти максимальное произведение двух её элементов,
    номера которых различаются не менее, чем на 8.
Значение каждого элемента последовательности не превышает 100 000. Количество элементов последовательности равно 100 000
Сгенерировать файл из случайных чисел и решить эту задачу
 */

using System;
using System.IO;

namespace BigSeries
{
    class Program
    {
        static void Save(string fileName, int n)
        {
            Random rnd = new Random();
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            for (int i = 1; i < n; i++)
            {
                bw.Write(rnd.Next(0, 100000));      // int занимает 4 байта
            }
            fs.Close();
            bw.Close();
        }

        static void Load(string fileName)
        {
            DateTime dt = DateTime.Now;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            int[] a = new int[fs.Length / 4];

            for (int i = 0; i < fs.Length / 4; i++)    // int занимает 4 байта
            {
                a[i] = br.ReadInt32();

            }
            br.Close();
            fs.Close();

            int max = 0;
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < a.Length; j++)
                    if (Math.Abs(i - j) >= 8 && a[i] * a[j] > max) max = a[i] * a[j];

            Console.WriteLine(max);
            Console.WriteLine($"{(DateTime.Now - dt).TotalSeconds:F2} сек.".Replace(',', '.'));
        }

        static void Main(string[] args)
        {
            Save("data.bin", 30000);
            Load("data.bin");
            Console.ReadLine();
        }
    }
}