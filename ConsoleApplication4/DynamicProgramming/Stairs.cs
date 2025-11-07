using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.DynamicProgramming
{
    public class Stairs
    {
        public static int Cal(int A)
        {
            
            if (A == 1)
            {
                return 1;
            }
            if (A == 2)
            {
                return 2;
            }
            return Cal(A - 1) + Cal(A - 2);
        }
    }
}
