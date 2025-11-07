using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Hashing
{
    public class DiffkII
    {
        public static int Find(List<int> A, int B)
        {
            if (null == A || A.Count == 0)
            {
                return 0;
            }

            Dictionary<int, int> diff = new Dictionary<int, int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (!diff.ContainsKey(A[i]))
                {
                    diff.Add(A[i], i);
                }

            }

            for (int i = 0; i < A.Count; i++)
            {
                if (diff.ContainsKey(A[i] - B))
                {
                    if (i != diff[A[i] - B])
                    {
                        return 1;
                    }
                }
            }

            return 0;
        }
    }
}
