using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.TwoPointers
{
    public class SortByColor
    {
        public static List<int> Sort(List<int> a)
        {
            int low = 0, mid = 0, hi = a.Count - 1;

            while (mid <= hi)
            {
                switch (a[mid])
                {
                    case 0:
                        Swap(a, low, mid);
                        low++;
                        mid++;
                        break;
                    case 1:
                        mid++;
                        break;
                    case 2:
                        Swap(a, mid, hi);
                        hi--;
                        break;
                }
            }

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            return a;
        }

        public static void Swap(List<int> a, int left, int right)
        {
            int temp = a[left];
            a[left] = a[right];
            a[right] = temp;
        }
    }
}
