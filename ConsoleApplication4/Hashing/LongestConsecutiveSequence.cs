using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Hashing
{
    public class LongestConsecutiveSequence
    {
        public static int Find(List<int> A)
        {
            if (null == A || A.Count == 0)
            {
                return 0;
            }
            Dictionary<int, int> temp = new Dictionary<int, int>();
            foreach (var item in A)
            {
                if (!temp.ContainsKey(item))
                {
                    temp.Add(item, item);
                }
            }
            int maxCount = 0;
            foreach (var item in A)
            {
                if (!temp.ContainsKey(item - 1))
                {
                    int localCount = 1;
                    int num = item;
                    while (true)
                    {
                        num += 1;
                        if (temp.ContainsKey(num))
                        {
                            localCount++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    maxCount = Math.Max(localCount, maxCount);
                }
            }

            return maxCount;
        }
    }
}