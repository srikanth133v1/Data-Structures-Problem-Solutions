using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.CodeFights
{
    public class sortedSquaredArray
    {
        public static int[] sortedSquaredArray1(int[] array)
        {
            var i = 0;
            for (; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    break;
                }
            }
            int[] t1 = new int[i];
            int[] t2 = new int[array.Length - i];

            for (var j = i - 1; j >= 0; j--)
            {
                t1[i - j - 1] = array[j] * array[j];
            }
            for (var k = i; k < array.Length; k++)
            {
                t2[k - i] = array[k] * array[k];
            }

            int[] t = new int[array.Length];
            int i1 = 0, i2 = 0, c = 0;
            while (i1 < t1.Length && i2 < t2.Length)
            {
                if (t1[i1] < t2[i2])
                {
                    t[c] = t1[i1];
                    i1++;
                    c++;
                }
                else
                {
                    t[c] = t2[i2];
                    i2++;
                    c++;
                }
            }

            while (i1 < t1.Length)
            {
                t[c] = t1[i1];
                c++;
                i1++;
            }

            while (i2 < t2.Length)
            {
                t[c] = t2[i2];
                c++;
                i2++;
            }
            return t;

        }
    }
}
