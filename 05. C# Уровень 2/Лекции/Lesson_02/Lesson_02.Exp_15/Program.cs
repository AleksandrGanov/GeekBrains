// Использование ключевого слова using

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_02.Exp_15
{
    class Program
    {
        static void Main()
        {
            using (SomeClass smc = new SomeClass()) { }
            GC.Collect();
            Console.ReadLine();
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