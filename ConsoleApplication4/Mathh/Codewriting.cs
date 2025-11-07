using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Mathh
{
    public class Codewriting
    {
        public static bool[] Solution(int[] numbers, int left, int right)
        {
            bool[] res = new bool[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                int t = numbers[i] / (i + 1);

                if (numbers[i] % (i + 1) == 0 && t >=left && t<=right)
                {
                    res[i] = true;
                }else
                {
                    res[i] = false;
                }
            }
            return res;
        }
    }
}
