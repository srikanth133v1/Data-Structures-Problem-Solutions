using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Strings
{
    public class ReverseTheString
    {
        public static string Reverse(string s)
        {
            string[] tokens = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return string.Join(" ", tokens.Reverse());
        }
    }

}
