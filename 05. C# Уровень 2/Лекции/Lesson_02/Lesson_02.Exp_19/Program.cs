// Exeptions: пример исправления нулевой ссылки при помощи перехвата исключения

using System;

namespace Lesson_02.Exp_19
{
    class X
    {
        int x;
        
        public X(int a)
        {
            x = a;
        }
        
        public int Add(X o)
        {
            return x + o.x;
        }
    }

    // Демонстрация NullReferenceException
    class NREDemo
    {
        static void Main()
        {
            X p = new X(10);
            X q = null; // В q специально присваиваем null 
            int val;
            
            try
            {
                // if (q == null) q = new X(10);
                val = p.Add(q); // Обращение приведет к исключению 
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException!");
                Console.WriteLine("исправляем...\n");
                // Теперь исправим
                q = new X(9);
                val = p.Add(q);
            }
            Console.WriteLine("Значение {0}", val);
            Console.ReadLine();
        }
    }
}