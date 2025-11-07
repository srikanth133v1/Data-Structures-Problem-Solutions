using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.CodeFights
{
    public class LongestIncreasingSubsequenceEO
    {
        public static int Cal(List<int> A)
        {
            A.Sort();
            return CalLength(A, 0, 0);
        }

        public static int Cal1(List<int> A)
        {
            int[] lengths = new int[A.Count];

            for (int i = 0; i < A.Count; i++)
            {
                lengths[i] = lengths[i - 1] + 1;
            }
            int maxSofar = 0;
            for (int k = 0; k < lengths.Length; k++)
            {
                maxSofar = Math.Max(maxSofar, lengths[k]);

            }
            return maxSofar;
        }

        public static int CalLength(List<int> A, int currentIndex, int maxLengthSoFar)
        {
            if (currentIndex == 0)
            {
                maxLengthSoFar = A[currentIndex];
                currentIndex++;
            }
            if (currentIndex == A.Count)
            {
                return maxLengthSoFar;
            }
            if (A[currentIndex] <= A[currentIndex + 1])
            {
                maxLengthSoFar = Math.Max(A[currentIndex + 1], A[currentIndex] + 1);
            }
            return CalLength(A, currentIndex + 1, maxLengthSoFar);
        }
    }
}
