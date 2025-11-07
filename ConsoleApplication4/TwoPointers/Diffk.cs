using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.TwoPointers
{
    public class Diffk
    {
        public static bool Find(List<int> a, int k)
        {
            int startIndex = 0, endIndex = 1;

            while (startIndex < a.Count && endIndex < a.Count)
            {
                if (startIndex == endIndex)
                {
                    endIndex++;
                }
                if (a[endIndex] - a[startIndex] == k)
                {
                    return true;
                }
                else if (a[endIndex] - a[startIndex] > k)
                {
                    startIndex++;
                }
                else
                {
                    endIndex++;
                }

            }
            
            return false;
        }
    }
}
