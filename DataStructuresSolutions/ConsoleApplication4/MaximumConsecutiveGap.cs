using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class MaximumConsecutiveGap
    {
        public int Gap(List<int> A)
        {
            if (null == A || A.Count <= 1)
            {
                return 0;
            }
            A.Sort();
            int diff = 0;
            for (int i = 0; i < A.Count - 1; i++)
            {
                diff = Math.Max(diff, Math.Abs(A[i + 1] - A[i]));
            }
            return diff;
        }
    }
}
