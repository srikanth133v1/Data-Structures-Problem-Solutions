using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.CodeFights
{
    public class Kbonacci
    {
        public static string kbonacci(int n, int k)
        {
            string[] s = new string[k];
            for (var i = 0; i < k; i++)
            {
                s[i] = "1";
            }
            for (var i = k; i <= n; i++)
            {
                string c = s[0];
                var j = 1;
                for (; j < s.Length; j++)
                {
                    c = addStrings(c, s[j]);
                    s[j - 1] = s[j];
                }
                s[j - 1] = c;
            }

            return new string(s[k - 1].Reverse().ToArray());
        }

        public static string addStrings(string s1, string s2)
        {
            StringBuilder sb = new StringBuilder();
            int carry = 0;
            var i = 0;
            for (; i < s1.Length && i < s2.Length; i++)
            {
                int sum = (s1[i] - '0') + (s2[i] - '0') + carry;
                carry = sum / 10;
                sum = sum % 10;
                sb.Append(sum);
            }
            string t = "";
            if (i < s1.Length)
            {
                t = s1;
            }
            else if (i < s2.Length)
            {
                t = s2;
            }
            while (i < t.Length)
            {
                int sum = (t[i] - '0') + carry;
                carry = sum / 10;
                sum = sum % 10;
                sb.Append(sum);
                i++;
            }

            if (carry > 0)
            {
                while (carry > 0)
                {
                    sb.Append(carry % 10);
                    carry = carry / 10;
                }
            }
            return sb.ToString();
        }
    }
}
