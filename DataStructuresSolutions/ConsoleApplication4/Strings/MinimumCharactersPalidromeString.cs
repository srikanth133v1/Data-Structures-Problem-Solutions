using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Strings
{
    public class MinimumCharactersPalidromeString
    {
        public static int Cal(string a)
        {
            int left = 0, right = a.Length - 1;
            int count = 0;
            int nextCount = 0;
            Console.WriteLine(a.Length);
            while (left <= right)
            {
                Console.WriteLine(a[left] + " " + a[right]);
                if (a[left] != a[right])
                {
                    right--;
                    count++;
                    nextCount = 0;
                }
                if (a[left] == a[right])
                {
                    nextCount++;
                    left++;
                    right--;
                    if (left <= right && a[left] != a[right])
                    {
                        left--;
                        if (left > 0)
                        {
                            left--;
                        }

                        count += nextCount;
                        nextCount = 0;
                    }
                }
            }

            return count;

        }

    }
}
