using System;
using System.Text;

// Изменямые строки System.Text.StringBuilder (использование свойств и методов)

namespace Lesson_05.Exp_08
{
    class Program
    {
        static void Main()
        {
            try
            {
                StringBuilder str = new StringBuilder("Площадь");
                PrintString(str);
                str.Append(" треугольника равна");
                PrintString(str);
                str.AppendFormat(" {0:f2} см ", 123.456);
                PrintString(str);
                str.Insert(8, "данного ");
                PrintString(str);
                str.Remove(7, 21);
                PrintString(str);
                str.Replace("а", "о");
                PrintString(str);
                Console.WriteLine("Введите первую строку для сравнения:");
                StringBuilder str1 = new StringBuilder(Console.ReadLine());
                Console.WriteLine("Введите вторую строку для сравнения:");
                StringBuilder str2 = new StringBuilder(Console.ReadLine());
                Console.WriteLine("Строки равны: " + str1.Equals(str2));
            }
            catch
            {
                Console.WriteLine("Возникло исключение");
            }
        }
        static void PrintString(StringBuilder a)
        {
            Console.WriteLine("Строка: " + a);
            Console.WriteLine("Текущая длина строки " + a.Length);
            Console.WriteLine("Объем буфера " + a.Capacity);
            Console.WriteLine("Максимальный объем буфера " + a.MaxCapacity);
            Console.WriteLine();
        }
    }
}
