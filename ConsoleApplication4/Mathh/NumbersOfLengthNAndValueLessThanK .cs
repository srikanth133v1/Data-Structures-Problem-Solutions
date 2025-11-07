using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Mathh
{
    public class NumbersOfLengthNAndValueLessThanK
    {
        public static int Find(List<int> a, int b, int c)
        {
            int count = a.Count;
            
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < a.Count; i++)
            {
                dict.Add(a[i], i);
            }

            List<int> digits = new List<int>();

            while (c > 0)
            {
                int rem = c % 10;
                digits.Add(rem);
                c = c / 10;
            }
            digits.Reverse();

            //foreach (var item in digits)
            //{
            //    Console.WriteLine(item);
            //}
            int rank = 1;
            for (int idx = 0; idx < digits.Count; idx++)
            {
                int i = 0;
                int smallNumCount = 0;

                while (i < a.Count && digits[idx] > a[i])
                {
                    //if (idx == 0 && a[i] == 0)
                    //{
                    //    i++;
                    //    continue;
                    //}
                    Console.WriteLine("a[i] " + a[i]);
                    smallNumCount++;
                    i++;

                }
                if (idx == 0)
                {
                    if (dict.ContainsKey(0))
                    {
                        rank = smallNumCount - 1;

                    }
                    else
                    {
                        rank = smallNumCount;
                    }

                }else
                {
                    rank = rank * (a.   Count);
                }



                //Console.WriteLine("smallNumCount " + smallNumCount);
                //int offset = b - idx;
                //if (smallNumCount > 1)
                //{
                //    if (dict.ContainsKey(0) && idx == 0)
                //    {
                //        rank = rank * (a.Count - 1);// * Power(smallNumCount, offset - 1) + 1;
                //    }
                //    else
                //    {
                //        rank = rank * a.Count; // + Power(smallNumCount, offset);
                //    }
                //}
                Console.WriteLine("rank " + rank);
            }

            return rank;
        }

        public static int Power(int b, int n)
        {
            int prod = 1;

            for (int i = 1; i <= n; i++)
            {
                prod *= b;
            }
            return prod;
        }
    }
}
