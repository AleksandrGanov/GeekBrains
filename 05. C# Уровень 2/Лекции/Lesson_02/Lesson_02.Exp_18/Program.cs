// Exeptions: пример сокрытия ошибок с помощью перехвата исключений

// Изящный способ сокрытия ошибок
// Из книги Герберта Шилдта «C# 4.0. Полное руководство»  (2011 г.)

using System;

namespace Lesson_02.Exp_18
{
    class ExcDemo3
    {
        static void Main()
        {
            int[] numer = { 4, 8, 16, 32, 64, 128 };
            int[] denom = { 2, 0, 4, 4, 0, 8 };
            
            for (int i = 0; i < numer.Length; i++)
            {
                try
                {
                    Console.WriteLine(numer[i] + " / " + denom[i] + " is " + numer[i] / denom[i]);
                }
                catch
                {
                    // Перехват исключения
                    Console.WriteLine("Делить на 0 нельзя");
                }
            }
            Console.ReadLine();
        }
    }
}