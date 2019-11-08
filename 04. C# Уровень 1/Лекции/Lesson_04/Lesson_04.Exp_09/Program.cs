using System;

// Пример простого перехвата исключения

namespace Lesson_04.Exp_09
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag; // Использование логической переменной в качестве флага
            do
            {
                Console.Write("Введите число: ");
                try
                {
                    flag = false; // Флаг опущен
                    int a = Convert.ToInt32(Console.ReadLine());
                    if (a==0) Console.WriteLine(a / 0); // симуляция ошибки деления на ноль
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Ошибка формата введенных данных: {ex.Message}".Replace('.',' ').Trim()) ;
                    flag = true; // Ошибка - подняли флаг
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Run-Time error: {ex.Message}".Replace('.', ' ').Trim()) ;
                    flag = true; // Ошибка - подняли флаг
                }
                finally
                {
                    Console.WriteLine("Окончание Try-Catch");
                }
            }
            while (flag); // Повторяем, пока флаг поднят
            Console.ReadLine();
        }
    }
}
