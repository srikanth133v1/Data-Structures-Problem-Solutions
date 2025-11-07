using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class PairwiseHammingDistance
    {
        public static int Distance(List<int> set)
        {
            if (null == set || set.Count <= 1)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < set.Count - 1; i++)
            {
                if (set[i] < 0)
                {
                    return 0;
                }
                for (int j = i + 1; j < set.Count; j++)
                {
                    // Console.WriteLine(set[i]);
                    sum += bitcount(set[i] ^ set[j]);
                    sum %= 1000000007;
                }
            }
            return (sum * 2) % 1000000007;
        }

        public static int CountSetBits(int n)
        {
            int count = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((n & (1 << i)) > 0)
                {
                    count++;
                }
            }
            return count;
        }
        public static int bitcount(int i)
        {
            i = i & 0x55555555 + (i >> 1) & 0x55555555;
            i = i & 0x33333333 + (i >> 2) & 0x33333333;
            i = i & 0x0f0f0f0f + (i >> 4) & 0x0f0f0f0f;
            i = i & 0x00ff00ff + (i >> 8) & 0x00ff00ff;
            return i & 0x0000ffff + (i >> 16) & 0x0000ffff;
        }

    }
}
