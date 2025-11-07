using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.DynamicProgramming
{
    public class JumpGameArray
    {
        public static int Find(List<int> A)
        {
            /*
             int[] jumps = new int[A.Count];
            int min;


            int i, j, n = A.Count;



            if (n == 0 || n != 1 && A[0] == 0)
                return 0;

            jumps[0] = 0;


            for (i = 1; i < n; i++)
            {
                jumps[i] = int.MaxValue;
                for (j = 0; j < i; j++)
                {
                    if (i <= j + A[j] && jumps[j] != int.MaxValue)
                    {
                        jumps[i] = Math.Min(jumps[i], jumps[j] + 1);
                        break;
                    }
                }
            }
            if (jumps[n - 1] != int.MaxValue)
            {
                return 1;
            }
            else
            {
                return 0;
            }
             */



            int[] jumps = new int[A.Count];
            int i, j;
            int min;
            if (A.Count == 0 || A.Count != 1 && A[0] == 0)
                return 0;
            jumps[A.Count - 1] = 0;

            for (i = A.Count - 2; i >= 0; i--)
            {
                if (A[i] == 0)
                {
                    jumps[i] = int.MaxValue;
                }
                else if (A[i] >= A.Count - i - 1)
                {
                    jumps[i] = 1;
                }
                else
                {
                    min = int.MaxValue;
                    for (j = i + 1; j < A.Count && j <= A[i] + i; j++)
                    {
                        if (min > jumps[j])
                        {
                            min = jumps[j];
                        }
                    }

                    if (min != int.MaxValue)
                    {
                        jumps[i] = min + 1;
                    }
                    else
                    {
                        jumps[i] = min;
                    }
                }
            }

            if (jumps[0] == int.MaxValue)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }
    }
}
