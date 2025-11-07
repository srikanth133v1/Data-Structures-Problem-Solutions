using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.CodeFights
{
    public class PeriodicSequence
    {
        public static int periodicSequence(int s0, int a, int b, int m)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            List<int> next = new List<int>();
            d.Add(s0, 1);
            next.Add(s0);
            int count = 1;

            while (true)
            {
                int nxt = CalculateNext(next[next.Count - 1], a, b, m);
                count++;
                if (!d.ContainsKey(nxt))
                {
                    d.Add(nxt, count);
                    next.Add(nxt);
                }
                else
                {
                    return d.Count - d[nxt] + 1;
                }
            }

            return -1;
        }

        public static int CalculateNext(int si, int a, int b, int m)
        {
            return ((si * a) % m + b % m) % m;
        }
    }
}
