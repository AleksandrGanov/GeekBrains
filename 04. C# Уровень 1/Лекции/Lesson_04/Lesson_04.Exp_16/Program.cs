using System;

/*
Задача 5. Задача на матрицу
Дан прямоугольный массив целых положительных чисел N х M, заполненный случайными числами. 
Описать на русском языке или на одном из языков программирования алгоритм поиска строки с наименьшей суммой элементов.
Вывести на печать номер строки и сумму её элементов. Если таких строк несколько, вывести информацию о каждой строке.
*/

namespace EGE_Matrix
{
    class Matrix
    {
        readonly int[,] a;         // Матрица
        int[] Rows;   // Сумма строк этой матрицы
        public Matrix(int n, int m)
        {
            a = new int[n, m];
            Random rnd = new Random();
            Rows = new int[n];
            for (int i = 0; i < n; i++)
            {
                int s = 0;
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rnd.Next(0, 9);
                    // Подсчет сумм каждой строки
                    s += a[i, j];
                }
                // Сохранение суммы для каждой строки
                Rows[i] = s;
            }
        }

        // Вывод матрицы на экран
        public void Print()
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write($"Строка №{i+1,2} |");
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    switch (a[i, j])
                    {
                        case 0:
                            Console.ForegroundColor = System.ConsoleColor.Red;
                            break;
                        case 1:
                            Console.ForegroundColor = System.ConsoleColor.Green;
                            break;
                        case 2:
                            Console.ForegroundColor = System.ConsoleColor.White;
                            break;
                        case 3:
                            Console.ForegroundColor = System.ConsoleColor.Blue;
                            break;
                        case 4:
                            Console.ForegroundColor = System.ConsoleColor.Cyan;
                            break;
                        case 5:
                            Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
                            break;
                        case 6:
                            Console.ForegroundColor = System.ConsoleColor.Yellow;
                            break;
                        case 7:
                            Console.ForegroundColor = System.ConsoleColor.Gray;
                            break;
                        case 8:
                            Console.ForegroundColor = System.ConsoleColor.DarkRed;
                            break;
                        case 9:
                            Console.ForegroundColor = System.ConsoleColor.DarkYellow;
                            break;
                    }
                    Console.Write("{0,2}", a[i, j]);
                }
                Console.ForegroundColor = System.ConsoleColor.White;
                Console.WriteLine(" |");
            }
            Console.WriteLine();
        }
        // Метод Search находит минимальную сумму и возвращает количество таких строк
        public int Search(out int count)
        {
            int min = int.MaxValue;
            count = 0;         // count описывать не нужно
            foreach (int e in Rows)
            {
                if (e < min) min = e;
            }
            foreach (int e in Rows)
            {
                if (e == min) count++;
            }
            return min;
        }
        // Находим все строки с такой же суммой
        public void SearchRows()
        {
            int min = Search(out _); ;
            for (int i = 0; i < Rows.Length; i++)
            {
                if (Rows[i] == min)
                {
                    Console.WriteLine($"Номер строки с мин.суммой элементов: {i+1}, значение: {Rows[i]}") ;
                }
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Matrix a = new Matrix(45, 45);
            a.Print();
            a.SearchRows();
            Console.ReadLine();
        }
    }
}
