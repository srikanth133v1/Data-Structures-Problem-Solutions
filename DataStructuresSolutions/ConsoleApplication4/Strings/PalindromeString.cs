using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Strings
{
    public class PalindromeString
    {
        public static bool Check(string s)
        {
            int left = 0, right = s.Length - 1;
            while (left <= right)
            {
                while (!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                while (!char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }

                if (!char.ToLower(s[left]).Equals(char.ToLower(s[right])))
                {
                    //Console.WriteLine(s[left] + " " + s[right]);
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

    }
}
