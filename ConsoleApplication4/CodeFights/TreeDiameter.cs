using ConsoleApplication4.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.CodeFights
{
    public class TreeDiameter
    {
        public static int Invoke(int n, int[,] tree)
        {
            Dictionary<int, List<int>> t = Build(tree);

            var f = BFS(tree[0, 0], t);

            return BFS(f.Item1, t).Item2;
        }

        public static Tuple<int, int> BFS(int start, Dictionary<int, List<int>> t)
        {
            Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
            q.Enqueue(new Tuple<int, int>(start, 0));
            HashSet<int> visited = new HashSet<int>();
            visited.Add(start);
            Tuple<int, int> maxSoFar = new Tuple<int, int>(start, 0);
            var temp = start;
            while (q.Count > 0)
            {
                var current = q.Dequeue();
                Console.WriteLine("Current: " + current.Item1);
                if (maxSoFar.Item2 < current.Item2)
                {
                    maxSoFar = current;
                }
                foreach (var item in t[current.Item1])
                {
                    if (!visited.Contains(item))
                    {
                        q.Enqueue(new Tuple<int, int>(item, current.Item2 + 1));
                        visited.Add(item);
                    }
                }
            }
            return maxSoFar;
        }

        public static Dictionary<int, List<int>> Build(int[,] tree)
        {
            Dictionary<int, List<int>> t = new Dictionary<int, List<int>>();

            for (int i = 0; i < tree.GetLength(0); i++)
            {
                if (!t.ContainsKey(tree[i, 0]))
                {
                    t.Add(tree[i, 0], new List<int>() { tree[i, 1] });
                }
                else
                {
                    t[tree[i, 0]].Add(tree[i, 1]);
                }
                if (!t.ContainsKey(tree[i, 1]))
                {
                    t.Add(tree[i, 1], new List<int>() { tree[i, 0] });
                }
                else
                {
                    t[tree[i, 1]].Add(tree[i, 0]);
                }
            }
            return t;
        }
    }
}
