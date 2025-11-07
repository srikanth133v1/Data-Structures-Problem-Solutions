using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Codility
{
    public class MeanFragments
    {
        //static int M_IDX = 100000;
        //static int M_SUM = 1000000000;

        //static int[,,] dp = new int[M_IDX, M_SUM, M_IDX];

        //static int Util(List<int> t, int idx, int sm, int c, int S)
        //{
        //    if (idx < 0 || idx == 0 && c == 0)
        //    {
        //        return 0;
        //    }

        //    if (idx == 0)
        //    {
        //        int rem = sm % c;

        //        if (rem != 0)
        //        {
        //            return 0;
        //        }
        //        int avg = sm / c;

        //        if (avg == S)
        //        {
        //            return 1;
        //        }
        //    }

        //    if (dp[idx, sm, c] != -1)
        //    {
        //        return dp[idx, sm, c];
        //    }

        //    int exclude = Util(t, idx - 1,
        //            sm, c, S);

        //    int include = Util(t, idx - 1,
        //            sm + t[idx],
        //            c + 1, S);
        //    int total = include + exclude;

        //    dp[idx, sm, c] = total;
        //    return total;
        //}

        //static int solution(int[] A, int S)
        //{
        //    List<int> t = new List<int>();

        //    t.Add(-1);
        //    for (int i = 0; i < A.Length; ++i)
        //    {
        //        t.Add(A[i]);
        //    }

        //    for (int i = 0; i < M_IDX; i++)
        //    {
        //        for (int j = 0; j < M_SUM; j++)
        //        {
        //            for (int k = 0; k < M_IDX; k++)
        //            {
        //                dp[i, j, k] = -1;
        //            }
        //        }
        //    }

        //    int answer = Util(t, A.Length, 0, 0, S);
        //    return answer;
        //}

        //no of avgs in subset with s
        public static int solution(int[] A, int S)
        {
            Dictionary<int, int> prefixes = new Dictionary<int, int>();
            int result = 0;
            int[] P = new int[A.Length + 1];
            prefixes.Add(0, 1);

            int[] Q = new int[A.Length + 1];
            P[0] = 0;
            Q[0] = 0;

            for (int i = 1; i < A.Length + 1; i++)
            {
                P[i] = P[i - 1] + A[i - 1];
                Q[i] = P[i] - S * i;

                if (!prefixes.ContainsKey(Q[i]))
                {
                    prefixes.Add(Q[i], 1);
                }
                else
                {
                    int t = prefixes[Q[i]];
                    t++;
                    prefixes[Q[i]]= t;

                }

            }

            foreach (var item in prefixes)
            {
                int value = item.Value;
                result += value * (value - 1) / 2;
            }

            return result;
        }
    }
}
