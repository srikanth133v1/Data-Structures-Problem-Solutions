using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.BinarySearch
{
    public class Power
    {
        public static int CalPower(int a, int b, int d)
        {
            int temp;
            if (b == 0)
            {
                return 1;
            }
            temp = (CalPower(a, b / 2, d) % d);
            //Console.WriteLine(temp);
            if (b % 2 == 0)
            {
                return (temp * temp) % d;
            }
            else
            {
                return (a * temp * temp) % d;
            }
        }
    }
}
