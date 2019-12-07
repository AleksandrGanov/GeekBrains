// Exeptions: пример перехвата исключений

using System;
using System.IO;

// Пример простого перехвата исключения
// Записываем в файл данные, введенные с клавиатуры
namespace Lesson7_Exception_002
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = null;
            try
            {
                var path = Path.Combine(@"C:\", "temp", "text.txt");
                sw = new StreamWriter(path);
                int a;
                do
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    sw.WriteLine(a);
                }
                while (a != 0);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода данных");
            }
            catch (IOException)
            {
                Console.WriteLine("Ошибка ввода/вывода");
            }
            catch (Exception exc)
            {
                Console.WriteLine("Неизвестная ошибка");
                Console.WriteLine("Информация об ошибке" + exc.Message);
            }
            finally
            {
                // Использование блока finally гарантирует, что набор операторов будет выполняться всегда, 
                // независимо от того, возникло исключение любого типа или нет)
                // в случае если sw!=null, то будет вызван метод закрытия sw
                sw?.Close();
            }
            Console.ReadLine();
        }
    }
}