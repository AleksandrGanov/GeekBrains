// Правило №4. Если алгоритму внутри каждого шага O(f(N)) одной операции приходится выполнять ещё O(g(N))
// шагов другой операции, то общая производительность алгоритма составит O(f(N) x g(N))

using System;

using static mlArray.ArrMaker;
using static mlConsole.PrintData;

namespace Lesson02.Exp04
{
    class Program
    {
        static int steps = 0;

        static void Main()
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                steps = 0;
                OTest(rnd.Next(1, 500));
            }
            Console.ReadLine();
        }
        private static void OTest(int arrLength, bool arrPrint=false)
        {
            int[] arr = IntRndArray(arrLength, 1, 100);
            int ans = FindDuplicates(arr);
            if (arrPrint)
            {
                Console.WriteLine($"Сгенеренный массив:");
                ArrPrint<int>(arr, 10);
            }
            if ((steps - 2) > 2) steps -= 2; // Проверка правила №3
            Console.WriteLine($"Кол-во элементов массива: {arr.Length}; Наличие дубликатов: {(ans.ToString() == "0" ? "Нет" : "Да")}, Кол-во шагов: {steps}");
        }
        static int FindDuplicates(int[] intArr)
        {
            steps++; // Присваиваем значение переменной i
            for (int i = 0; i < intArr.Length && intArr.Length > 1; i++)
            {
                steps++; // Исполнение цикла
                steps++; // Присваиваем значение переменной j
                for (int j = 0; j < intArr.Length; j++)
                {
                    steps++; // Исполнение цикла
                    if (i != j) if (intArr[i] == intArr[j])
                        {
                            steps++;  return 1;
                        }
                }
            }
            steps++; return 0;
        }
    }
}