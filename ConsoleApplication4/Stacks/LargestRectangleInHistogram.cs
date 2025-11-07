using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Stacks
{
    public class LargestRectangleInHistogram
    {
        public static int Area(List<int> A)
        {
            Stack<int> s = new Stack<int>();

            int area = 0;

            int i = 0;

            while (i < A.Count)
            {
                if (s.Count == 0 || A[s.Peek()] <= A[i])
                {
                    s.Push(i);
                    i++;

                }
                else
                {
                    int right = s.Peek();
                    s.Pop();
                    area = Math.Max(area, (s.Count == 0 ? i : (i - s.Peek() - 1)) * A[right]);
                }

            }

            while (s.Count != 0)
            {
                int right = s.Peek();
                s.Pop();
                area = Math.Max(area, (s.Count == 0 ? i : (i - s.Peek() - 1)) * A[right]);
            }
            return area;

        }
    }
}
