// Реализация интерфейса IEnumerable с использованием ключевого слова yield


using System;
using System.Collections; // Необходим для интерфейса IEnumerable

namespace Interfaces_060_MyClass_and_Foreach_2
{
    class MyClass : IEnumerable
    {
        private readonly int[] _mass;
        private readonly int[] _bass;

        public MyClass(int n)
        {
            _mass = new int[n];
            _bass = new int[n];
            for (int i = 0; i < n; i++)
            {
                _mass[i] = i;
                _bass[i] = i;
            }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _mass.Length; i++)
                yield return _bass[i];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass(10);
            foreach (var m in mc) {
                Console.WriteLine($"{m}, тип: {m.GetType()}"); }

            Console.ReadLine();
        }


    }
}