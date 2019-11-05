using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// статические поля и методы

namespace Lesson_03.Exp_08
{
    class MyClass
    {
        public static int static_a;
        public int non_static_a;
    }

    class Program
    {
        static void Main()
        {
            MyClass.static_a = 10;
            MyClass myobj = new MyClass();
            myobj.non_static_a = 10;
        }
    }
}
