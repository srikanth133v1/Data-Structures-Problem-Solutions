using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication4.CodeFights
{
    public class SumUpNumbers
    {
        public static int sumUpNumbers(string i)
        {
            Regex r = new Regex(@"\d+");
            MatchCollection m = r.Matches(i);
            int s = 0;
            foreach (Match mt in m)
            {
                s += Convert.ToInt32(mt.Value);
            }
            return s;
        }

    }
}
