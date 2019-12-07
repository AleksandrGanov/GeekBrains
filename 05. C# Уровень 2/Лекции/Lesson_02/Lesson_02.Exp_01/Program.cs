// Интерфейсы #1

using System;

namespace Interface_sample
{
    class Program
    {
        static void Main()
        {
            IEnumerator e = new Countdown();
            Console.WriteLine(e.Current);
            while (e.MoveNext())
            {
                Console.WriteLine(e.Current); // 109876543210
            }
            Console.Read();
        }
    }
    internal class Countdown : IEnumerator
    {
        private int _count = 20;

        public object Current => _count;
        public bool MoveNext() => _count-- > 0;
    }
    public interface IEnumerator
    {
        object Current { get; }
        bool MoveNext();
    }
}
