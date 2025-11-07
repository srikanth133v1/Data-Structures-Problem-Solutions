using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Backtracking
{
    public class Permutations
    {
        public static void Collect(List<int> A, int length, List<List<int>> perm)
        {
            List<int> l = new List<int>();
            for (int i = 0; i < length; i++)
            {
                l.Add(A[i]);
            }
            perm.Add(l);
        }
        public static void Generate(List<int> A, int size, int length, List<List<int>> perm)
        {
            if (size == 1)
            {
                Collect(A, length, perm);
            }

            for (int i = 0; i < size; i++)
            {
                Generate(A, size - 1, length, perm);

                if (size % 2 == 1)
                {
                    int temp = A[size - 1];
                    A[size - 1] = A[0];
                    A[0] = temp;
                }
                else
                {
                    int temp = A[i];
                    A[i] = A[size - 1];
                    A[size - 1] = temp;
                }
            }
        }
    }
}
