using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.TwoPointers
{
    public class MinimizeTheAbsoluteDifference
    {
        public static int Diff(List<int> a, List<int> b, List<int> c)
        {
            int minSofar = Int32.MaxValue;

            int i = 0, j = 0, k = 0;
            int cI = 0, cJ = 0, cK = 0;

            while (i < a.Count && j < b.Count && k < c.Count)
            {
                int max = Math.Max(Math.Max(a[i], b[j]), c[k]);
                int min = Math.Min(Math.Min(a[i], b[j]), c[k]);

                int diff = Math.Abs(max - min);
                Console.WriteLine(max + " " + min);
                if (diff < minSofar)
                {
                    cI = i;
                    cJ = j;
                    cK = k;
                    minSofar = diff;
                }
                Console.WriteLine(a[i] + " " + b[j] + " " + c[k]);
                if (minSofar == 0)
                {
                    break;
                }

                if (a[i] == min)
                {
                    i++;
                }
                else if (b[j] == min)
                {
                    j++;
                }
                else
                {
                    k++;
                }

            }

            return minSofar;
        }
    }
}
