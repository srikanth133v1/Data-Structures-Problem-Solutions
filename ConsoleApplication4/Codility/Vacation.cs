using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Codility
{
    public class Vacation
    {
        //find shortest vacation trips
        public int solution(int[] A)
        {
            if (A.Length <= 1)
            {
                return A.Length;
            }

            var sIdx = 0;
            var eIdx = 0;
            var visited = new int[A.Length];
            visited[A[0] - 1] = 1;

            for (var i = 1; i < A.Length; i++)
            {
                visited[A[i] - 1]++;
                if (A[i] == A[i - 1])
                {
                    continue;
                }
                eIdx = i;

                while (visited[A[sIdx] - 1] > 1)
                {
                    visited[A[sIdx] - 1]--;
                    sIdx++;
                }
            }
            return eIdx - sIdx;
        }
    }
}
