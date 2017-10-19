using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.TwoPointers
{
    public class IntersectionOfSortedArrays
    {
        public static void Intersect(List<int> a, List<int> b)
        {
            int i = 0, j = 0;

            List<int> intersect = new List<int>();
            for (i = 0, j = 0; i < a.Count && j < b.Count;)
            {
                if (a[i] == b[j])
                {
                    intersect.Add(a[i]);
                    i++;
                    j++;
                }
                else if (a[i] < b[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            foreach (var item in intersect)
            {
                Console.WriteLine(item);
            }

        }
    }
}
