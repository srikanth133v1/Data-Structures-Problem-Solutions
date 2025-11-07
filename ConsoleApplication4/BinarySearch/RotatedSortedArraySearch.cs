using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.BinarySearch
{
    public class RotatedSortedArraySearch
    {

        public static int Find(List<int> A, int x)
        {
            int min = FindMin(A);
            Console.WriteLine(min);
            if (min >= 0)
            {
                int res = Search(A, min, A.Count - 1, x);
                Console.WriteLine(res);
                if (res == -1 || res > A.Count - 1 || res < min)
                {
                    res = Search(A, 0, min, x);
                    if (res > min)
                    {
                        return -1;
                    }
                }
                return res;
            }
            else
            {
                return -1;
            }

        }

        public static int Method2(List<int> A, int x)
        {
            int l = 0, h = A.Count;
            while (l <= h)
            {
                int mid = (l + h) / 2;
                if (A[mid] == x)
                {
                    return mid;
                }
                if (A[mid] >= A[l])
                {
                    if (x >= A[l] && x < A[mid])
                    {
                        h = mid - 1;
                    }else
                    {
                        l = mid + 1;
                    }
                }else
                {
                    if(x>A[mid] && x <= A[h])
                    {
                        l = mid + 1;
                    }else
                    {
                        h = mid - 1;
                    }
                }
            }
            return -1;
        }

        public static int Search(List<int> A, int low, int high, int x)
        {
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
            return -1;
        }
        public static int FindMin(List<int> A)
        {
            int low = 0, high = A.Count - 1;
            int count = A.Count;
            while (low <= high)
            {
                if (A[low] <= A[high])
                {
                    return low;
                }

                int mid = (low + high) / 2;
                int prev = (mid - 1 + count) % count;
                int next = (mid + 1) % count;

                if (A[mid] <= A[prev] && A[mid] <= A[next])
                {
                    return mid;
                }
                else if (A[mid] <= A[high])
                {
                    high = mid - 1;
                }
                else if (A[mid] >= A[low])
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
    }
}
