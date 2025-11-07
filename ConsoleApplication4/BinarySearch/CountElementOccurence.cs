using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.BinarySearch
{
    public class CountElementOccurence
    {
        public int findCount(List<int> A, int B)
        {
            if (null == A || A.Count == 0)
            {
                return 0;
            }
            int firstIndex = Search(A, B, true);
            if (firstIndex == -1)
            {
                return 0;
            }
            else
            {
                int lastIndex = Search(A, B, false);
                return lastIndex - firstIndex + 1;
            }

        }
        public static int Search(List<int> A, int B, bool searchFirst)
        {

            int low = 0, high = A.Count - 1, result = -1;

            while (low <= high)
            {

                int mid = low + (high - low) / 2;

                if (A[mid] == B)
                {

                    result = mid;

                    if (searchFirst)
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }

                }
                else if (B < A[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }

            }
            return result;

        }
    }
}
