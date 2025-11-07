using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Codility
{
    public class PeopleCars
    {
        //p=1,4,1 s=1,5,1
        //4,4,2,4  -> 5,5,2,5

        //sort 
       
        public static int Solution(int[] P, int[] S)
        {
            Array.Sort(S);
            Array.Reverse(S);
            int sum = 0;
            for (int i = 0; i < P.Length; i++)
            {
                sum = P[i] + sum;
            }
            int j = 0;
            for (; j < S.Length; j++)
            {
                sum = sum - S[j];
                if (sum <= 0)
                {
                    break;
                }
            }
            
            return j+1;
        }
    }
}
