using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.DynamicProgramming
{
    public class MinSumPathInMatrix
    {
        public static int Cal(List<List<int>> A)
        {
            int[,] sum = new int[A.Count, A[0].Count];
            int i = 0, j = 0;
            sum[0, 0] = A[0][0];
            for (int row = 1; row < A.Count; row++)
            {
                sum[row, 0] = sum[row - 1, 0] + A[row][0];
            }
            for (int column = 1; column < A[0].Count; column++)
            {
                sum[0, column] = sum[0, column - 1] + A[0][column];
            }

            for (i = 1; i < A.Count; i++)
            {
                for (j = 1; j < A[0].Count; j++)
                {
                    sum[i, j] = Math.Min(sum[i, j - 1], sum[i - 1, j]) + A[i][j];
                }
            }

            return sum[A.Count - 1, A[0].Count - 1];
        }
    }
}
