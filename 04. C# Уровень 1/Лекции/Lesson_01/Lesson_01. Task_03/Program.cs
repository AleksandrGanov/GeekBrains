// Обменять значениями две переменные a и b

namespace Lesson_01.Exp_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;     // Присваиваем начальное значение
            int b = 20;     // Присваиваем начальное значение
            int t = a;        // В t запоминаем значение a
            a = b;           // В a записываем b
            b = t;           // В b записываем сохраненное a
        }
    }
}
