// Ключевое слово Base

using System;

namespace Lesson_01.Exp_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("мурка", 5, 100);
            Console.ReadLine();
        }
    }

    public class Animals
    {
        private string _name;
        private int _numberPaws;
        public Animals(string name, int numberPaws)
        {
            _name = name;
            _numberPaws = numberPaws;
        }
    }
    public sealed class Cat : Animals
    {
        private ushort? _lengthTail;
        public Cat(string name, int numberPaws, ushort? lengthTail) : base(name,
            numberPaws)
        {
            _lengthTail = lengthTail;
        }
    }
}
