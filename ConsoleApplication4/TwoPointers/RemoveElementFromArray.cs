using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.TwoPointers
{
    public class RemoveElementFromArray
    {
        public static List<int> Remove(List<int> a, int k)
        {
            for (int i = a.Count - 1; i >= 0; i--)
            {
                if (a[i] == k)
                {
                    a.RemoveAt(i);
                }
            }

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            return a;
        }
    }
}
