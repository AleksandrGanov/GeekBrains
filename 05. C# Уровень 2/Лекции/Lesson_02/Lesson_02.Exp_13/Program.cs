// Комбинированное использование деструктора и интерфейса IDisposable

using System;

namespace Lesson_02.Exp_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            GC.Collect();
            Console.ReadLine();
        }
        static void Test()
        {
            SomeClass smc = new SomeClass();
        }
    }

    public class SomeClass : IDisposable
    {
        private bool disposed = false;

        // реализация интерфейса IDisposable.
        public void Dispose()
        {
            Dispose(true);
            // подавляем финализацию
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Освобождаем управляемые ресурсы
                }
                // освобождаем неуправляемые объекты
                disposed = true;
                Console.WriteLine("Disposed Unmanaged");
            }
        }

        // Деструктор
        ~SomeClass()
        {
            Dispose(false);
            Console.WriteLine("Disposed");
        }
    }
}
