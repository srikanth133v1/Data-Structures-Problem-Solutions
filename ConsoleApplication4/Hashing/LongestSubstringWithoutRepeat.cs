using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Hashing
{
    public class LongestSubstringWithoutRepeat
    {
        public static int Find(string A)
        {
            if (string.IsNullOrEmpty(A))
            {
                return 0;
            }
            int[] visited = new int[256];
            for (int i = 0; i < 256; i++)
            {
                visited[i] = -1;
            }
            int curr_len = 1;
            int max_len = 1;
            visited[A[0]] = 0;
            int prev_idx;
            for (int i = 1; i < A.Length; i++)
            {
                prev_idx = visited[A[i]];

                if (prev_idx == -1 || i - curr_len > prev_idx)
                {
                    curr_len++;
                }
                else
                {
                    if (curr_len > max_len)
                    {
                        max_len = curr_len;
                    }
                    curr_len = i - prev_idx;
                }
                visited[A[i]] = i;
            }
            if (curr_len > max_len)
            {
                max_len = curr_len;
            }
            return max_len;
        }
    }
}
