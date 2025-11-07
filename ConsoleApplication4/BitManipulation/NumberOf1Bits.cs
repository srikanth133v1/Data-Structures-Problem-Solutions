using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.BitManipulation
{
    public class NumberOf1Bits
    {
        public static uint Count(uint a)
        {
            uint count = 0;
            uint right = 1;
            //Console.WriteLine(right<<1);
            //return 1;
            while (right > 0)
            {
                if ((a & right) > 0)
                {
                    count++;

                }
                // Console.WriteLine(right);
                right = right << 1;
            }
            return count;
        }
    }
}
