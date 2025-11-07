using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Stacks
{
    public class MinStack
    {
        List<int> s = new List<int>();
        public void push(int x)
        {
            s.Add(x);
        }
        public void pop()
        {
            if (s.Count == 0)
            {
                return;
            }
            s.RemoveAt(s.Count - 1);
        }
        public int getMin()
        {
            if (s.Count == 0)
            {
                return -1;
            }
            int min = Int32.MaxValue;
            for (int i = 0; i < s.Count; i++)
            {
                min = Math.Min(min, s[i]);
            }
            return min;
        }
        public int top()
        {
            if (s.Count == 0)
            {
                return -1;
            }
            return s[s.Count - 1];
        }

    }
}
