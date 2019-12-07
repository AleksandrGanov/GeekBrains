// Пример загрузки данных в класс с массивом и сортировка через реализацию IComparable

using System;
using System.IO;

namespace HW_TaskEGE
{
    class Element : IComparable
    {
        private readonly string _fio;
        private readonly int _ball;

        public Element(string fio, int ball)
        {
            _fio = fio;
            _ball = ball;
        }

        public string FIO => _fio;
        public int Ball => _ball;
        public int CompareTo(object obj)
        {
            if (_ball < ((Element)obj).Ball) return 1;
            if (_ball > ((Element)obj).Ball) return -1;
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("data.txt");
            int n = Int32.Parse(sr.ReadLine());
            Element[] list = new Element[n];

            for (var i = 0; i < n; i++)
            {
                string[] s = sr.ReadLine().Split(' ');
                int ball = Int32.Parse(s[2]) + Int32.Parse(s[3]) + Int32.Parse(s[4]);
                list[i] = new Element(s[0] + " " + s[1], ball);
            }
            sr.Close();
            Array.Sort(list);
            Array.Reverse(list);

            foreach (var v in list)
            {
                Console.WriteLine(@"{0,20}{1,10}", v.FIO, v.Ball);
            }

            Console.WriteLine();

            int ball2 = list[0].Ball;
            int counter = 1;
            foreach (var v in list)
            {
                if (v.Ball >= ball2 & counter < 3)
                {
                    Console.WriteLine("{0,20}{1,10}", v.FIO, v.Ball);
                    if (v.Ball >ball2) counter++;
                };
            }
            Console.ReadLine();
        }
    }
}