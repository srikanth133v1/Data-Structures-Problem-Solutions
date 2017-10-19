using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class FirstMissingInteger
    {
        public static int Find(List<int> A)
        {
            int maxNum = 0;

            Dictionary<int, int> num = new Dictionary<int, int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] > 0)
                {
                    maxNum = Math.Max(maxNum, A[i]);
                    num.Add(A[i], A[i]);
                }
            }

            for (int i = 1; i <= maxNum; i++)
            {
                if (!num.ContainsKey(i))
                {
                    return i;
                }
            }

            return maxNum + 1;
        }
    }
}
