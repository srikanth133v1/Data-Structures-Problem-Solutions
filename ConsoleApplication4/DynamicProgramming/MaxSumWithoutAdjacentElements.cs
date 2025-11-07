using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.DynamicProgramming
{
    public class MaxSumWithoutAdjacentElements
    {
        public static int Cal(List<List<int>> A)
        {


            if (null == A || A.Count == 0)
            {
                return 0;
            }
            if (A[0].Count == 1)
            {
                return Math.Max(A[0][0], A[1][0]);
            }
            int sumIncl = Math.Max(A[0][0], A[1][0]);
            int sumExcl = 0, tempExcl = 0;

            for (int i = 1; i < A[0].Count; i++)
            {
                tempExcl = Math.Max(sumExcl, sumIncl);
                sumIncl = sumExcl + Math.Max(A[0][i], A[1][i]);

                sumExcl = tempExcl;
            }

            return Math.Max(sumExcl, sumIncl);
        }
        //public static int Cal(List<List<int>> A)
        //{


        //    if (null == A || A.Count == 0)
        //    {
        //        return 0;
        //    }
        //    if (A[0].Count == 1)
        //    {
        //        return Math.Max(A[0][0], A[1][0]);
        //    }

        //    int[,] sum = new int[2, A[0].Count];



        //    sum[0, 0] = A[0][0];
        //    sum[0, 1] = A[0][1];
        //    sum[1, 0] = A[1][0];
        //    sum[1, 1] = A[1][1];
        //    int maxSoFar = Math.Max(Math.Max(sum[0, 0], sum[1, 0])
        //       , Math.Max(sum[0, 1], sum[1, 1]));

        //    for (int i = 2; i < A[0].Count; i++)
        //    {
        //        for (int j = 0; j < 2; j++)
        //        {
        //            int localMax = 0;
        //            for (int k = 0; k < i - 1; k++)
        //            {
        //                for (int m = 0; m < 2; m++)
        //                {
        //                    localMax = Math.Max(localMax, sum[m, k]);
        //                }
        //            }
        //            sum[j, i] = localMax + A[j][i];// Math.Max(sum[0, i - 2], sum[1, i - 2]) + A[j][i];
        //            maxSoFar = Math.Max(maxSoFar, sum[j, i]);
        //        }
        //    }

        //    return maxSoFar;
        //}
    }
}
