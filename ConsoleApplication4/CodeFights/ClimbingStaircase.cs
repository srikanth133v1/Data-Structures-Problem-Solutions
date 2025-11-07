using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.CodeFights
{
    public class ClimbingStaircase
    {
        public static int[][] climbingStaircase(int n, int k)
        {
            List<List<int>> comb = new List<List<int>>();

            List<List<int>> paths = new List<List<int>>();
            //for (int i = 1; i <= k; i++)
            //{
                paths.Add(new List<int>());
                Generate(paths, paths.Count - 1, 0, k, n, comb);

            //}
            //comb.Distinct();

            int[][] res = new int[comb.Count][];

            for (var i = 0; i < comb.Count; i++)
            {
                res[i] = new int[comb[i].Count];
                for (var j = 0; j < comb[i].Count; j++)
                {
                    res[i][j] = comb[i][j];
                }
            }
            return res;
        }
        public static void Generate(List<List<int>> paths, int idx, int current, int k, int n, List<List<int>> vPaths)
        {

            if (n < 0)
            {
                return;
            }
            Console.WriteLine("idx: " + idx + " , current: " + current);

            if (n == 0)
            {
                vPaths.Add(paths[idx]);
                return;
            }
            else
            {
                //paths[idx].Add(current);
                //n = n-current;
                for (int i = 1; i <= k; i++)
                {
                    if (n - i < 0)
                    {
                        continue;
                    }
                    List<int> temp = new List<int>(paths[idx]);
                    temp.Add(i);
                    paths.Add(temp);
                    Generate(paths, paths.Count - 1, i, k, n - i, vPaths);
                }
            }

        }

    }
}
