using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.DynamicProgramming
{
    public class MinJumpsArray
    {
        public static int Cal(List<int> A)
        {
            int length = A.Count;

            if (length <= 1)
            {
                return 0;
            }
            if (A[0] == 0)
            {
                return -1;
            }
            int maxReach = A[0];
            int step = A[0];
            int jump = 1;

            int i = 1;

            for (;i  < length; i++)
            {
                if (i == length - 1)
                {
                    return jump;
                }

                maxReach = Math.Max(maxReach, A[i] + i);

                step--;

                if (step == 0)
                {
                    jump++;

                    if (i >= maxReach)
                    {
                        return -1;
                    }
                    step = maxReach - i;
                }
            }
            return -1;
        }

        public static int Cal1(List<int> A)
        {
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
                return -1;
            }
            else
            {
                return jumps[0];
            }
        }
    }
}
