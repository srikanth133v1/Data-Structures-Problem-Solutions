using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class AntiDiagonal
    {
        public static List<List<int>> Print(List<List<int>> A)
        {
            if (null == A || A.Count == 0)
            {
                return A;
            }
            List<List<int>> diag = new List<List<int>>();
            int rowCount = A.Count;
            int colCount = A[0].Count;

            int i = 0, j = 0, left = 0, right = colCount, top = 0, bottom = rowCount;

            for (int col = left; col < right; col++)
            {
                i = 0;
                j = col;
                List<int> lstRow = new List<int>();
                while (i >= 0 && j >= 0 && i < rowCount && j < colCount)
                {
                    Console.WriteLine("i: {0} j: {1} k: {2} a[i][j]: {3}", i, j, col, A[i][j]);
                    lstRow.Add(A[i][j]);
                    i++;
                    j--;
                }
                diag.Add(lstRow);
            }

            for (int row = top + 1; row < bottom; row++)
            {
                i = row;
                j = colCount - 1;
                List<int> lstRow = new List<int>();
                while (i >= 0 && j >= 0 && i < rowCount && j < colCount)
                {
                    Console.WriteLine("i: {0} j: {1} k: {2} a[i][j]: {3}", i, j, row, A[i][j]);
                    lstRow.Add(A[i][j]);
                    i++;
                    j--;
                }
                diag.Add(lstRow);
            }


            for (i = 0; i < diag.Count; i++)
            {
                foreach (var item in diag[i])
                {
                    Console.WriteLine("row: " + i + "item: " + item);
                }

            }


            return diag;
        }
    }
}
