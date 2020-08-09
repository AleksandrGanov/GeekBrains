// Обобщения

namespace Lesson_03.Exp_01
{
    class Program
    {
        static void Main()
        {
        }

        // Необобщенные методы
        static void Swap(ref double a, ref double b)
        {
            double t;
            t = a;
            a = b;
            b = t;
        }
        static void Swap(ref object a, ref object b)
        {
            object t;
            t = a;
            a = b;
            b = t;
        }

        // Обобщенный метод
        static void Swap2<T>(ref T A, ref T B)
        {
            T t;
            t = A;
            A = B;
            B = t;
        }
    }
}