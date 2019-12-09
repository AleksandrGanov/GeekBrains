using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr = new object[3] { new String(new char[1] {'a'}), new String(new char[1] { 'b' }), new String(new char[1] { 'c' }) };
            Array.Clear(arr, 1, 1);
            Console.ReadLine();
        }
    }
}
