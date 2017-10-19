using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Strings
{
    public class LengthOfLastWord
    {
        public static int CalLength(string s)
        {
            if (null == s || s.Length == 0)
            {
                return 0;
            }
            int i = -1;
            int length = 0;
            bool hasChar = false;
            for (i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    if (hasChar)
                    {
                        break;
                    }
                }
                else
                {
                    hasChar = true;
                    length++;
                }
            }
            return length;
        }
    }
}
