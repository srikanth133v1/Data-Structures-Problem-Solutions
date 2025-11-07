using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Codility
{
   public class FirstNonPositive
    {
        public static int Seggregate(int[] A)
        {
            int j = 0;
            for(int i=0; i < A.Length; i++)
            {
                if (A[i] <= 0)
                {
                    int t = A[i];
                    A[i] = A[j];
                    A[j] = t;
                    j++;
                }

            }
            return j;
        }

        public static int FindMissingPositive(int[] A)
        {
            int max = A.Max();
            if (max < 1)
            {
                return 1;
            }
            if (A.Length == 1)
            {
                if (A[0] == 1)
                {
                    return 2;
                }else
                {
                    return 1;
                }
            }
            int []l = new int[max];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    if (l[A[i] - 1] != 1)
                    {
                        l[A[i] - 1] = 1;
                    }
                }
                
            }
            int j = 0;
            for (j = 0; j < l.Length; j++)
            {
                if (l[j] == 0)
                {
                    return j + 1;
                }
            }
            return j+2;
        }

        public int solution(int[] A)
        {
            if (A.Length > 100000)
            {
                return -1;
            }
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int[] t = new int[1000000 + 1];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && A[i] <= 1000000)
                {
                    t[A[i]] += 1;
                }
            }
            for (int j = 1; j < t.Length; j++)
            {
                if (t[j] == 0)
                {
                    return j;
                }
            }
            return -1;
        }


    }
}
