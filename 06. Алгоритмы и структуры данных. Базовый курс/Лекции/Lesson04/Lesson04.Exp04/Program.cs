// Наибольшая общая последовательность (LCS longest common subsequence)

using System;

using static mlConsole.PrintData;

namespace Lesson04.Exp04
{
    class Program
    {
        static void Main()
        {
            string s1 = "GEEKBRAINS", s2 = "GEEKMINDS";
            LCSCycle(s1, s2);
            Console.ReadLine();
        }
        static void LCSCycle(string s1, string s2)
        {
            int rowDim = s1.Length+1, colDim = s2.Length+1;
            int[,] arrInt = new int[rowDim, colDim];
            char[,] arrChar= new char[rowDim, colDim];
            char[] arrCommon = new char[colDim-1];

            #region Борта матриц
            for (int i = 1; i < rowDim + 1; i++) arrInt[i - 1, 0] = 1;
            for (int j = 1; j < colDim + 1; j++) arrInt[0, j - 1] = 1;
            for (int j = 0; j < colDim-1; j++) arrCommon[j] = '0';

            for (int i = 1; i < rowDim; i++) arrChar[i, 0] = s1[i - 1];
            for (int j = 1; j < colDim; j++) arrChar[0, j] = s2[j - 1]; 
            #endregion

            for (int i = 1; i < rowDim; i++)
            {
                for (int j = 1; j < colDim; j++)
                {
                    if (s1[i - 1] == s2[j - 1]&& s1[i - 1]!=' ')
                    {
                        arrInt[i, j] = arrInt[i - 1, j - 1] + 1;
                        arrChar[i, j] = s1[i-1];
                        arrCommon[j - 1] = s1[i - 1];
                    }
                    #region unused
                    else if (arrInt[i - 1, j] >= arrInt[i, j - 1])
                    {
                        arrInt[i, j] = arrInt[i - 1, j];
                        arrChar[i, j] = ' ';
                    }
                    else
                    {
                        arrInt[i, j] = arrInt[i, j - 1];
                        arrChar[i, j] = ' ';
                    }
                    #endregion
                }
            }

            //TwoDimArrayPrint(arrInt, 3, "arrInt");
            TwoDimArrayPrint(arrChar, 1, "arrChar");
            Console.Write("LCS: "); foreach (var item in arrCommon) if (item != '0') Console.Write(item);
        }
    }
}