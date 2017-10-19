using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.BitManipulation
{
    public class SingleNumber
    {
        public static int Find(List<int> A)
        {
            int xor = A[0];
            for (int i = 1; i < A.Count; i++)
            {
                xor = xor ^ A[i];
            }
            //Console.WriteLine(xor);
            return xor;
        }
    }
}
