using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.CodeFights
{
    public class SortByString
    {
        public static string sortByString(string s, string t)
        {
            int[] a = new int[26];

            for (var i = 0; i < t.Length; i++)
            {
                a[t[i] - 'a'] = i;
            }
            char[] c = s.ToCharArray();
            Array.Sort(c, (x, y) =>
            {
                if (a[x - 'a'] < a[y - 'a'])
                {
                    return -1;
                }
                else if (a[x - 'a'] > a[y - 'a'])
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            });
            return new string(c);
        }
    }
}
