using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Sorting
{
    public class BubbleSort
    {
        public static void Sort(List<int> A)
        {
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < A.Count - i - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        int temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = temp;
                    }
                }
            }
        }
    }
}
