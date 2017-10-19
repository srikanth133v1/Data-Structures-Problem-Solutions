using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Rearrange
    {
        public static List<int> Arrange(List<int> A)
        {
            if (null == A || A.Count == 0)
            {
                return A;
            }
            for (int i = 0; i < A.Count; i++)
            {
                Console.WriteLine(A[i]);
                A[i] += (A[A[i]] % A.Count) * A.Count;
            }
            Console.WriteLine("arranged");
            for (int i = 0; i < A.Count; i++)
            {
                A[i] = A[i] / A.Count;
                Console.WriteLine(A[i]);
            }

            return A;
        }
    }
}
