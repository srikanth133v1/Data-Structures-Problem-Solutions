using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.CodeFights
{
    public class DigitRootSort
    {
        public static int[] digitRootSort(int[] a)
        {
            Array.Sort(a, (x, y) =>
            {
                int left = GetSum(x);
                int right = GetSum(y);
                if (left < right)
                {
                    return -1;
                }
                else if (left > right)
                {
                    return 1;
                }
                else
                {
                    if (x < y)
                    {
                        return -1;
                    }
                    else if (x > y)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            });
            return a;
        }
        public static int GetSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int temp = num % 10;
                num = num / 10;
                sum += temp;
            }
            return sum;
        }
    }
}
