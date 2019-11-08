using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Задача 3. Частотный массив
В частотном массиве мы как бы выворачиваем массив наизнанку.
В частотном массиве индексы массива соответствуют его элементам.
Значения - это количество элементов.
Поэтому нужно понять, что размер частотного массива связан с диапазоном чисел, которые мы подсчитываем
*/

namespace SeriesN_ЧастотныйМассив
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int imax = 0;
            int N = 10;
            int rndNum = N * 5;
            int[] a = new int[N];
            int[] mass = new int[rndNum];

            do
            {
                Array.Clear(mass,0,mass.Length-1);
                Console.Clear();

                // Заполняем массив случайными числами
                for (int i = 0; i < N; i++)
                    a[i] = rnd.Next(0, rndNum);

                // Выводим массив на экран
                Console.Write("Исходный массив: |");
                foreach (var v in a) Console.Write(v + "|");

                // Подсчитываем вхождение элементов 
                foreach (var v in a) mass[v]++; // Элемент массива a является номером в частотном массиве mass

                // Находим максимальный элемент в частотном массиве

                for (int i = 0; i < mass.Length; i++)
                    if (mass[i] > mass[imax]) imax = mass[i];
            } while (imax==1);

            // выводим сам частотный массив
            Console.Write("\nЧастотный массив: |");
            foreach (var i in mass)
            {
                if (mass[i]!=0) Console.Write(i + "|");
            }

            // Выводим все элементы, которые в частотном массиве встречались то же количество раз, что и imax
             Console.Write($"\nМакс. частотность: {imax}\nЧисла с макс. частотой: |") ;
            for (int i = 0; i < mass.Length; i++)
                if (mass[i] == imax) Console.Write(i + "|");
            Console.ReadLine();
        }
    }
}
