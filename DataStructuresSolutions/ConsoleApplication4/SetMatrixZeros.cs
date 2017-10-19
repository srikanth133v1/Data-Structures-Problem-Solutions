using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class SetMatrixZeros
    {
        public static List<List<int>> Set(List<List<int>> A)
        {
            int[] row = new int[A.Count];
            int[] col = new int[A[0].Count];
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < A[0].Count; j++)
                {
                    if (A[i][j] == 0)
                    {
                        row[i] = 1;
                        col[i] = 1;
                    }
                }
            }

            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < A[0].Count; j++)
                {
                    if (row[i] == 1)
                    {
                        A[i][j] = 0;
                    }
                    if (col[j] == 1)
                    {
                        A[i][j] = 0;
                    }
                }
            }

            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < A[0].Count; j++)
                {
                    Console.WriteLine(A[i][j]);
                }
            }


            return A;
        }
    }
}
