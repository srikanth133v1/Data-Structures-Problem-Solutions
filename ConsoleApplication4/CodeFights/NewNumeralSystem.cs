using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.CodeFights
{
    public class NewNumeralSystem
    {
        public static List<string> Find(char ch)
        {
            int num = ch - 'A';
            int mid = (num % 2 == 0) ? num / 2 : (num / 2) + 1;
            List<string> s = new List<string>();
            for (int i = 0; i <= num/2; i++)
            {
                s.Add(string.Format("{0} + {1}", (char)(i + 'A'), (char)(num - i + 'A')));
            }

            return s;
        }
    }
}
