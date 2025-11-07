using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.CodeFights
{
    public class LeastAppearance
    {
        public static int[] leastAppearance(int[][] s)
        {
            var t = new Dictionary<int, List<Node>>();
            for (var i = 0; i < s.Length; i++)
            {

                if (!t.ContainsKey(s[i][0]) && !t.ContainsKey(s[i][1]))
                {
                    int m = Math.Min(s[i][0], s[i][1]);
                    t.Add(m, new List<Node>() { new Node() { Idx = i, V = m } });
                }
                else if (!t.ContainsKey(s[i][0]))
                {
                    t.Add(s[i][0], new List<Node>() { new Node() { Idx = i, V = s[i][0] } });
                }
                else if (!t.ContainsKey(s[i][1]))
                {
                    t.Add(s[i][1], new List<Node>() { new Node() { Idx = i, V = s[i][1] } });
                }
                else
                {
                    int m = t[s[i][0]].Count == t[s[i][1]].Count
                        ? Math.Min(t[s[i][0]][0].V, t[s[i][1]][0].V)
                        : (t[s[i][0]].Count < t[s[i][1]].Count ?
                            t[s[i][0]][0].V : t[s[i][1]][0].V);
                    t[m].Add(new Node() { Idx = i, V = m });
                }
            }

            var r = t.Values.SelectMany(x => x).ToList();
            r.Sort((x, y) => x.Idx.CompareTo(y.Idx));
            return r.Select(x => x.V).ToArray();
        }

        public class Node
        {
            public int Idx { get; set; }
            public int V { get; set; }
        }
    }
}
