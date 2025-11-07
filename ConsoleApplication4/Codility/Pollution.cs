using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Codility
{
    public class Pollution
    {
        public static int Solution(int[] A)
        {
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum = sum + A[i];
            }
            int t = sum;
               
            Array.Sort(A);
            Array.Reverse(A);
            int count = 0;
            bool exit = false;
            while (!exit)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[j] > 0)
                    {
                        A[j] = A[j] / 2;
                        sum = sum - (A[j] / 2);
                        count++;
                        if (sum * 2 < t)
                        {
                            exit=true;
                        }
                    }
                }
            }
            
            return count;
        }
    }
}
