// Массив массивов

using System;

namespace Lesson_04.Exp_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявление массива массивов(ступенчатый массив)
            int[][] jaggedArray = new int[3][];
            // Пример заполнения первого элемента ступенчатого массива
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[5] { 1, 2, 3, 4, 5 };
            jaggedArray[2] = new int[3] { 1, 2, 3 };

            //Array.Resize(ref jaggedArray[0], 6);
            //jaggedArray[1].CopyTo(jaggedArray[0],0);
        }
    }
}
