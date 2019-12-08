// Exeptions: Перехват исключений. Использование блока finall

// Пример перехвата исключения в зависимости от типа

using System;

class Program
{
    static void Main(string[] args)
    {
        System.IO.StreamWriter sw = null;
        try
        {
            sw = new System.IO.StreamWriter("data.txt");
            Console.WriteLine("Введите напряжение:");
            int u = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сопротивление:");
            int r = int.Parse(Console.ReadLine());
            int i = u / r;
            Console.WriteLine("Сила тока - " + i);
            sw.WriteLine("При напряжении {0} и сопротивлении {1} сила тока:", u, r, i);
            sw.Close();
        }
        catch (FormatException e)
        {
            Console.WriteLine("Неверный формат ввода! " + e.Message);
            return;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Деление на 0!");
        }
        catch (Exception e) // Общий случай 
        {
            Console.WriteLine("Неопознанное исключение" + e);
        }
        finally
        {
            if (sw != null) sw.Close();
            Console.WriteLine("Закрываем используемые ресурсы");
            Console.ReadKey();
        }
    }
}
