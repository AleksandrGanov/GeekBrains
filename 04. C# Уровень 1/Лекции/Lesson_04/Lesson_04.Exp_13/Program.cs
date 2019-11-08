using System;
using System.IO;

// Задача 2. Массив и файл

namespace SeriesN_SortMaxMinMiddle
{
    class MyArray
    {
        readonly int[] a;

        public MyArray()
        {
            a = new int[1];
        }
        public MyArray(string filename)
        {
            StreamReader sr = new StreamReader(@"..\..\" + filename);
            // Считываем количество элементов массива
            int N = int.Parse(sr.ReadLine());
            a = new int[N];
            // Считываем массив
            for (int i = 0; i < N; i++)
            {
                a[i] = int.Parse(sr.ReadLine());
            }
            sr.Close();
        }
        
        public int Length
        {
            get {
                return a.Length;
            }
        }
        public double Sum
        {
            get {
                double sum = 0;
                foreach (int el in a)
                    sum += el;
                return sum;
            }
        }
        public int Max
        {
            get {
                // Находим максимальный элемент
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get {
                // Находим минимальный элемент
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        
        public void BubbleSort()
        {
            // Сортируем методом пузырька
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < a.Length - 1; j++)
                    if (a[j] > a[j + 1])//Сравниваем соседние элементы
                    {
                        // Обмениваем элементы местами
                        int t = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = t;
                    }
        }
        public void Print()
        {
            foreach (int el in a)
                Console.Write($"{el,4}");
            Console.WriteLine();
        }
        public void Print(string msg)
        {
            Console.WriteLine(msg);
            Print();
        }
    }
    class Program
    {
        static void Main()
        {
            //MyArray a = new MyArray();
            MyArray a = new MyArray("SampleData.txt");
            Console.Write("Считанный ряд данных: ");
            a.Print();
            Console.WriteLine($"\nMax: {a.Max}");
            Console.WriteLine($"Min: {a.Min}");
            Console.WriteLine($"Middle: {a.Sum / a.Length}\n".Replace(',','.'));
            a.BubbleSort();
            a.Print("Отсортированный массив");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}