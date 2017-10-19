using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class MaxDistance
    {
        public static int Distance(List<int> A)
        {
            if (null == A || A.Count == 0)
            {
                return -1;
            }
            if (A.Count == 1)
            {
                return 0;
            }
            int count = A.Count, maxDiff = -1, i = 0, j = 0;

            int[] leftMin = new int[count];

            leftMin[0] = A[0];
            for (i = 1; i < count; i++)
            {
                leftMin[i] = Math.Min(A[i], leftMin[i - 1]);
            }
            int[] rightMax = new int[count];

            rightMax[count - 1] = A[count - 1];
            for (j = count - 2; j >= 0; --j)
            {
                rightMax[j] = Math.Max(A[j], rightMax[j + 1]);
            }
            i = 0; j = 0;

            while (i < count && j < count)
            {
                if (leftMin[i] <= rightMax[j])
                {
                    maxDiff = Math.Max(maxDiff, j - i);
                    j++;
                }
                else
                {
                    i++;
                }
            }
            return maxDiff;
        }
    }
}
