using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Level3
{
    public class Kthsmallest
    {
        public static int Find(List<int> A, int B)
        {
            if (null == A || B >= A.Count || A.Count == 0)
            {
                return -1;
            }

            for (int i = 0; i < B; i++)
            {
                int minAt = i;
                for (int j = i; j < A.Count; j++)
                {
                    if (A[j] < A[minAt])
                    {
                        minAt = j;
                    }
                }
                int temp = A[i];
                A[i] = A[minAt];
                A[minAt] = temp;
            }
            return A[B - 1];

        }


        //public static int Find(List<int> A, int B)
        //{
        //    int start = 0, end = A.Count - 1;

        //    return FindElement(A, start, end, B-1);

        //}

        //public static int FindElement(List<int> A, int p, int q, int B)
        //{
        //    int num = -1;
        //    while (p < q)
        //    {
        //        int idx = QuickSort.Partition(A, p, q);
        //        Console.WriteLine("idx: " + idx + " A[idx]" + A[idx]);
        //        if (idx < B)
        //        {
        //            p = idx + 1;
        //            idx = QuickSort.Partition(A, p, q);
        //        }
        //        else if (idx > B)
        //        {
        //            q = idx - 1;
        //            idx = QuickSort.Partition(A, p, q);
        //        }
        //        Console.WriteLine("idx2: " + idx + " A[idx]" + A[idx]);
        //        if (idx == B)
        //        {
        //            return A[idx];
        //        }
        //    }
        //    return num;
        //}
    }
}
