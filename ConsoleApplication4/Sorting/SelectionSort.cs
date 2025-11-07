using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Sorting
{
    public class SelectionSort
    {
        public static void Sort(List<int> A)
        {
            for (int i = 0; i < A.Count; i++)
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
        }
    }
}
