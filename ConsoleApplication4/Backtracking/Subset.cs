using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Backtracking
{
    public class Subset
    {
        public static void Collect(Stack<int> q, SortedDictionary<string, List<int>> subsets)
        {
            List<int> l = q.ToList();
            l.Sort();
            
            subsets.Add(string.Join("", l.ToArray()), l);
            
            q = new Stack<int>();
        }
        public static void Generate(List<int> A, Stack<int> q, int size, int length, SortedDictionary<string, List<int>> subsets)
        {
            if (null == q)
            {
                q = new Stack<int>();
            }

            if (size == length)
            {
                Collect(q, subsets);
            }
            else
            {
                Generate(A, q, size + 1, length, subsets);
                q.Push(A[size]);
                Generate(A, q, size + 1, length, subsets);
                q.Pop();

            }
        }
    }
}
