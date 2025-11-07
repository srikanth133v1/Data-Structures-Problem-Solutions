using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.BinarySearch
{
    public class MedianOfArray
    {
        public static int Find(List<int> a, List<int> b)
        {
            int totalCount = a.Count + b.Count;
            //int median = totalCount / 2;

            int topLow = 0, topHigh = a.Count - 1;
            int bottomLow = 0, bottomHigh = b.Count - 1;

            while ((topHigh - topLow > 1) && (bottomHigh - bottomLow) > 1)
            {
                int topMid = (topLow + topHigh) / 2;
                int bottomMid = (bottomLow + bottomHigh) / 2;

                if (a[topMid] == b[topMid])
                {
                    Console.WriteLine(a[topMid]);
                }

                if (a[topMid] < b[bottomMid])
                {
                    topLow = topMid + 1;
                    bottomHigh = bottomMid - 1;
                }
                else if (a[topMid] > b[bottomMid])
                {
                    bottomLow = bottomMid + 1;
                    topHigh = topMid - 1;
                }

            }
            Console.WriteLine(topLow + " " + topHigh);
            Console.WriteLine(bottomLow + " " + bottomHigh);
            //Median = (max(ar1[0], ar2[0]) + min(ar1[1], ar2[1])) / 2
            int median = (Math.Max(a[topLow], b[topLow]) + Math.Min(a[topHigh], b[topHigh])) / 2;
            Console.WriteLine(median);

            return -1;
        }
    }
}
