using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.BinarySearch
{
    public class SortedInsertPosition
    {
        public static int Find(List<int> A, int x)
        {
            int low = 0, high = A.Count - 1;
            int count = A.Count;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (A[mid] == x)
                {
                    return mid;
                }


                if (x < A[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return low;
        }

    }
}
