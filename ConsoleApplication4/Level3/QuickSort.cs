using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Level3
{
    public class QuickSort
    {
        //public static int Find(List<int> A, int B)
        //{
        //    int min = Int32.MaxValue;
        //    Dictionary<int, int> minLst = new Dictionary<int, int>();
        //    int minAt = 0;
        //    int lastMin = Int32.MaxValue;
        //    while (minLst.Count < B)
        //    {
        //        //Console.WriteLine(minLst.Count);
        //        for (int i = 0; i < A.Count; i++)
        //        {
        //            if (A[i] < min && !minLst.ContainsKey(i))
        //            {
        //                min = A[i];
        //                minAt = i;
        //            }
        //        }
        //        //Console.WriteLine("minAt "+ minAt + " min "+min);

        //        minLst.Add(minAt, min);
        //        lastMin = min;
        //        min = Int32.MaxValue;

        //    }

        //    return lastMin;
        //}

        public static void Sort(List<int> A)
        {
            QSort(A, 0, A.Count - 1);
            for (int i = 0; i < A.Count; i++)
            {
                Console.WriteLine(A[i]);
            }
        }

        public static void QSort(List<int> A, int p, int q)
        {
            if (p < q)
            {
                int idx = Partition(A, p, q);
                QSort(A, idx + 1, q);
                QSort(A, p, idx - 1);
            }
        }

        public static int Partition(List<int> A, int start, int end)
        {
            int pivot = A[end];
            int pIndex = start - 1;
            for (int i = start; i <= end - 1; i++)
            {
                if (A[i] <= pivot)
                {
                    pIndex++;
                    Swap(A, i, pIndex);
                }
            }
            pIndex++;
            Swap(A, pIndex, end);
            return pIndex;
        }
        public static void Swap(List<int> A, int left, int right)
        {
            int temp = A[left];
            A[left] = A[right];
            A[right] = temp;

        }
    }
}
