using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.BitManipulation
{
    public class ReverseBits
    {
        public static uint Reverse(uint a)
        {
            int count = 0;
            uint right = 1;

            uint reverse = 0;
            uint offset = 1;
            List<int> lstBits = new List<int>();
            while (right > 0)
            {
                count++;
                if ((a & right) > 0)
                {

                    reverse |= offset << (32 - count);
                }

                right = right << 1;
            }
            return reverse;
        }
    }
}
