using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.TwoPointers
{
    public class FirstLast
    {
        public static int[] Solution(int[] nums)
        {
            int[] res = new int[nums.Length];
            int l = 0, r = nums.Length - 1;
            int c = 0;
            while (l <= r)
            {
                res[c] = nums[l];
                c++;
                res[c] = nums[r];
                c++;
                l++;
                r--;
            }
            return res;
        }
    }
}
