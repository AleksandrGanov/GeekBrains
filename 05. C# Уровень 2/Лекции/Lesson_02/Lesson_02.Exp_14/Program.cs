// Dispose() для базового класса в случае наследования от класса, реализующего интерфейс IDisposable

using System;

namespace Lesson_02.Exp_14
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
            Derived drv = new Derived();
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
    public class Derived : SomeClass
    {
        private bool IsDisposed = false;

        protected override void Dispose(bool disposing)
        {
            if (IsDisposed) return;
            if (disposing)
            {
                // Освобождение управляемых ресурсов
            }
            // Освобождаем нуправляемые ресурсы
            IsDisposed = true;
            Console.WriteLine("Disposed Unmanaged Derived");
            // Обращение к методу Dispose базового класса
            base.Dispose(disposing);
        }
    }
}
