// Рекурсия, пример №3. Как работает рекурсия (задача ЕГЭ)

using System;

namespace Lesson02.Exp08
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i < 30; i++) Console.WriteLine($"i={i}: {F(i).ToString()}-{G(i).ToString()}");
            Console.ReadLine();
        }
        static int F(int n)
        {
            if (n > 2) return F(n - 1) + G(n - 2);
            else return n; 
        }
        static int G(int n)
        {
            if (n > 2) return G(n - 1) + F(n - 2);
            else return 3-n;
        }
    }
}