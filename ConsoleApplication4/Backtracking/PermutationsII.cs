using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Backtracking
{
    public class PermutationsII
    {
        public static List<List<int>> Result { get; set; }
        public static void ListAll(List<int> A)
        {
            Generate(A, 0);

        }
        public static void Generate(List<int> A, int start)
        {
            if (start == A.Count - 1)
            {
                var temp = new List<int>();
                foreach (var item in A)
                {
                    temp.Add(item);
                }
                if (null == Result)
                {
                    Result = new List<List<int>>();
                }
                Result.Add(temp);
                return;
            }
            for (var i = start; i < A.Count; i++)
            {
                Swap(A, start, i);
                Generate(A, start + 1);
                Swap(A, start, i);
            }

        }
        public static void Swap(List<int> A, int l, int r)
        {
            int t = A[l];
            A[l] = A[r];
            A[r] = t;
        }
    }
}
