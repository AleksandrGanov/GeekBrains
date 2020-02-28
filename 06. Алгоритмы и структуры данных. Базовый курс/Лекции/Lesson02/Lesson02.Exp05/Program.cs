// Правило №5. Постоянными множителями (константами) можно пренебречь. Если C является константой, то O(C x
// f(N)) или O(f(C x N)) можно записать как O(f(N))

using System;

using static mlArray.ArrMaker;
using static mlConsole.PrintData;

namespace Lesson02.Exp05
{
    class Program
    {
        static int steps = 0;

        static void Main()
        {
            Random rnd = new Random();
            for (int i = 0; i < 30; i++) OTest(i*20);
            Console.ReadLine();
        }
        private static void OTest(int arrLength, bool arrPrint = false)
        {
            steps = 0;
            int[] arr = IntRndArray(arrLength, 1, 1000);
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
                            return 1; // Принебрегаем шагом возврата
                        }
                }
            }
            steps++; return 0;
        }
    }
}