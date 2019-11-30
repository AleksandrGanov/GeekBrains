// IS и AS #2

using System;

namespace IsAs020
{
    class MyObject
    {
    }

    class MyObject2 : MyObject
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyObject obj1 = new MyObject();
            MyObject2 obj2 = new MyObject2();
            MyObject obj = obj1 as MyObject;

            if (obj != null) Console.WriteLine("Мы теперь можем обращаться к c obj как MyObject");
            obj = obj2 as MyObject2;
            if (obj != null) Console.WriteLine("Мы теперь можем обращаться к c obj как MyObject2");
        }
    }
}