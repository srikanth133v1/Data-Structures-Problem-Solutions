using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class NobleInteger
    {
        public static int Query(List<int> A)
        {
            A.Sort();
            for (int i = 0; i < A.Count-1; i++)
            {
                //int count = 0;
                if (A[i + 1] != A[i] && A[i] == A.Count - 1 - i)
                {
                    return 1;
                }
                
                //for (int j = 0; j < A.Count; j++)
                //{
                //    if (A[j] > A[i])
                //    {
                //        count++;
                //    }
                //}

                //if (count == A[i])
                //{
                //    return 1;
                //}
            }
            if (A[A.Count - 1] == 0) {
                return 1;
            }
            return -1;

        }
    }
}
