using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.DynamicProgramming
{
    public class MaxSumSubArray
    {
        public static int Find(List<int> A)
        {
            int minSum = 0, maxSum = 0, sum = 0;
            for (int i = 0; i < A.Count; i++)
            {
                sum += A[i];
                if (sum < minSum)
                {
                    minSum = sum;
                }
                if (maxSum < sum - minSum)
                {
                    maxSum = sum - minSum; 
                }
            }
            return maxSum;
        }
    }
}
