using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class INVERSIONS
    {

        public static int Cal(List<int> A)
        {
            int[] temp = new int[A.Count];

            return MergeSort(A, temp, 0, A.Count - 1); 

        }



        public static int Merge(List<int> A, int[] temp, int left, int mid, int right)
        {
            int count = 0;
            int i = left, j = mid, idx = left;
            while (i <= mid-1 && j <= right)
            {
                if (A[i] > A[j])
                {
                    temp[idx] = A[j];
                    count+=(mid-i);
                    j++;
                }
                else
                {
                    temp[idx] = A[i];
                    i++;
                }
                idx++;

            }

            while (i <= mid - 1)
            {
                temp[idx] = A[i];
              //  count++;
                i++;
                idx++;
            }

            while (j <= right)
            {
                temp[idx] = A[j];
                j++;
                idx++;
            }

            for (i = left; i <= right; i++)
            {
                A[i] = temp[i];
            }
            return count;
        }
        public static int MergeSort(List<int> A, int[] temp, int left, int right)
        {
            if (left >= right)
            {
                return 0;
            }
            int count = 0, mid = (left + right) / 2;
            count = MergeSort(A, temp, left, mid);
            count += MergeSort(A, temp, mid + 1, right);
            return count + Merge(A, temp, left, mid + 1, right);
        }


        public static int Cal1(List<int> A)
        {
            int count = 0;
            for (int i = 0; i < A.Count - 1; i++)
            {
                for (int j = i; j < A.Count; j++)
                {
                    if (A[i] > A[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
