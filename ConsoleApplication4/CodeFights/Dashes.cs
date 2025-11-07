using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.CodeFights
{
    public class Dashes
    {
        public static string[] dashes(int n)
        {
            List<string> s = new List<string>();
            char[] c = new char[2 * n - 1];
            for (var i = 0; i < c.Length; i++)
            {
                if (i == (n - 1))
                {
                    c[i] = '-';
                }
                else
                {
                    c[i] = ' ';
                }

            }
            s.Add(new string(c));
            for (var i = 1; i < n; i++)
            {
                if (c[n - 1] == '-')
                {
                    c[n - 1] = '|';
                }
                else if (c[n - 1] == '|')
                {
                    c[n - 1] = '-';
                }
                for (var j = n - 1; j >= n - i; j--)
                {
                    if (c[j] == '|')
                    {
                        c[j - 1] = '-';
                        c[(n - 1) + (n - j)] = '-';
                    }
                    else if (c[j] == '-')
                    {
                        c[j - 1] = '|';
                        c[(n - 1) + (n - j)] = '|';
                    }
                }
                s.Add(new string(c));
            }
            for (var k = n - 2; k >= 0; k--)
            {
                s.Add(s[k]);
            }
            return s.ToArray();
        }

    }
}
