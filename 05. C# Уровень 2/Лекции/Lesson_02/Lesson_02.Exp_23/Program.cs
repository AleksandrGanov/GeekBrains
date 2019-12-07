// Как научить foreach работать с вашими данными?

/*
Пример необходимости реализации интерфейсов IEnumerable и IEnumerator
Здесь показано, как научить foreach работать с вашими данными
Для циклического обращения к элементам коллекции зачастую проще (да и лучше) организовать 
цикл foreach, чем пользоваться непосредственно методами интерфейса IEnumerator
Если требуется создать класс, содержащий объекты, перечисляемые в цикле foreach, то 
в этом классе следует реализовать интерфейсы IEnumerator и IEnumerable
Чтобы обратиться к объекту определяемого пользователем класса в цикле foreach, 
необходимо реализовать интерфейсы IEnumerator и IEnumerable в их обобщенной или 
необобщенной форме.
*/

using System;
using System.Collections;

namespace Interfaces_060_MyClass_and_Foreach
{
    class MyClass : IEnumerable, IEnumerator
    {
        private readonly int[] _a; // Наш пользовательский тип данных
        private int _i = -1; // Первоначально индекс указывает на -1, так как к переходу к следующему мы увеличим его на 1

        public MyClass(int n)
        {
            _a = new int[n];
            // Заполняем его произвольными данными
            for (var i = 0; i < n; i++) _a[i] = i;
        }
        
        // Реализуем интерфейс IEnumerable
        // Этот интерфейс должен только вернуть объект типа IEnumerator, который будет заниматься перечислением элементов
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        // реализуем интерфейс IEnumerator
        public object Current => _a[_i];
        public bool MoveNext()
        {
            if (_i == _a.Length - 1)
            {
                Reset();
                return false;
            }
            _i++;
            return true;
        }
        public void Reset()
        {
            _i = -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass(5);
            foreach (var m in my) { Console.Write("{0,4}", m); }
            Console.ReadLine();
        }
    }
}