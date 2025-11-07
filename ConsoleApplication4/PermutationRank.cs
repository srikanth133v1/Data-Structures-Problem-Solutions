using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Solution
    {
        /*
         Sorted Permutation Rank

Given a string, find the rank of the string amongst its permutations sorted lexicographically. 
Assume that no characters are repeated.
Example :
Input : 'acb'
Output : 2

The order permutations with letters 'a', 'c', and 'b' : 
abc
acb
bac
bca
cab
cba
The answer might not fit in an integer, so return your answer % 1000003
             */
        public int findRank(string A)
        {
            if (null == A || A.Length == 0)
            {
                return 0;
            }
            char[] c = A.ToArray();
            Array.Sort(c);

            //foreach (var item in c)
            //{
            //    Console.WriteLine(item);
            //}

            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < c.Length; i++)
            {
                dic.Add(c[i], i);
            }
            int rank = 1;
            List<int> visitedIndexes = new List<int>();
            for (int i = 0; i < A.Length - 1; i++)
            {
                int index = dic[A[i]];
                foreach (var item in visitedIndexes)
                {
                    if (index > item)
                    {
                        index--;
                    }
                }

                visitedIndexes.Add(index);

                // index = index - i;
                if (index < 0)
                {
                    continue;
                }
                // Console.WriteLine(index);
                int offset = A.Length - i - 1;
                //Console.WriteLine(offset);
                int prod = (index * Factorial(offset) % 1000003);
                //Console.WriteLine(prod);
                rank = rank % 1000003 + prod % 1000003;

            }
            return rank % 1000003;
        }
        public static int Factorial(int n)
        {
            int prod = 1;
            for (int i = 1; i <= n; i++)
            {
                prod = prod % 1000003 * i % 1000003;
            }
            return prod % 1000003;
        }


    }

}
