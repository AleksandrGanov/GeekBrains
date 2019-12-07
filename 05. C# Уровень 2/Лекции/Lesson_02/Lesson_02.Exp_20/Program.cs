// Exeptions: генерация собственных исключений #1

using System;

namespace Lesson_02.Exp_20
{
    class MyException : Exception
    {
        public MyException()
        {
            Console.WriteLine(base.Message);
        }
    }

    class ThrowDemo
    {
        static void Main()
        {
            //  DateTime date = new DateTime(2016, 13, 40);
            try
            {
                Console.WriteLine("До возникновения исключения.");
                throw new MyException();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Перехват исключения.");
            }
            catch (MyException)
            {
                Console.WriteLine("Сработало мое исключение!.");
            }
            Console.WriteLine("После блока обработки try/catch.");
            Console.ReadLine();
        }
    }
}