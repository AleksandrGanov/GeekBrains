// Поиск с возвратом (backtracking). Задача о восьми ферзях

using System;
using static mlConsole.PrintData;

namespace Lesson04.Exp05
{
    class Program
    {
        static void Main()
        {
            int rowDim = 8, colDim = 8;
            int[,] arrDesk = new int[rowDim, colDim];
            int queensNum = 0;

            FillWithNumber(arrDesk, 0);
            arrDesk[0, 5] = 1; // Сами ставим ферзь в строку №1
            arrDesk[1, 3] = 1; // Сами ставим ферзь в строку №2
            foreach (var item in arrDesk) if (item != 0) queensNum += item; // Ищем кол-во уже установленных ферзей

            SearchSolution(queensNum+1, arrDesk); // Поиск начинаем с количества уже установленных ферзей + 1
            TwoDimArrayPrint(arrDesk, 2);
            Console.ReadLine();
        }
        static int SearchSolution(int n, int[,] arr)
        {
            int rowDim = arr.GetLength(0), colDim = arr.GetLength(0);
            if (CheckBoard(arr) == 0) return 0; // Если проверка доски возвращает 0, то расстановка не подходит
            if (n == 9) return 1; // Если номер ферзя равен 9, то решение найдено (то есть все ферзи расставлены)
            for (int i = 0; i < rowDim; i++)
                for (int j = 0; j < colDim; j++)
                    if (arr[i, j] == 0)
                    {
                        arr[i, j] = n; // Расширяем тестируемое решение
                        if (SearchSolution(n + 1, arr)==1) return 1; // Рекурсивно проверяем ведет ли данный вариант к решению
                        arr[i, j] = 0; // Если дошли до этой строки, то данное частичное решение не приводит, откатываемся к предыдущему решению
                    }
            return 0;
        }
        static int CheckBoard(int[,] arr)
        { // Проверка всей доски
            int rowDim = arr.GetLength(0), colDim = arr.GetLength(0);
            for (int i = 0; i < rowDim; i++)
                for (int j = 0; j < colDim; j++)
                    if (arr[i, j] != 0)
                        if (CheckQueen(i, j, arr) == 0) return 0;
            return 1;
        }
        static int CheckQueen(int x, int y, int[,] arr)
        { // Проверка определенного ферзя
            int rowDim = arr.GetLength(0), colDim = arr.GetLength(0);
            for (int i = 0; i < rowDim; i++)
                for (int j = 0; j < colDim; j++)
                    if (arr[i, j] != 0)
                        if (!(i == x && j == y)) // Проверяем наша ли это фигура
                        {
                            if (i - x == 0 || j - y == 0) return 0; // Проверяем лежат ли фигуры на одной горизонтали
                            if (Math.Abs(i - x) == Math.Abs(j - y)) return 0; // Проверяем лежат ли фигуры на одной диагонали
                        }
            return 1; // Если дошли сюда и не вышли ни по одну return, то все ОК, фигуры "не пересекаются"
        }
        static void FillWithNumber<T>(T[,] arr, T value)
        { // Заполнение всего массива одинаковыми значениями
            int rowDim = arr.GetLength(0), colDim = arr.GetLength(0);
            for (int i = 0; i < rowDim; i++) for (int j = 0; j < colDim; j++) arr[i, j] = value;
        }
    }
}