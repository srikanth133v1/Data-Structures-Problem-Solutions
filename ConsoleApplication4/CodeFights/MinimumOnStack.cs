using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.CodeFights
{
    public class MinimumOnStack : Stack<int>
    {
        public static int[] minimumOnStack(string[] operations)
        {
            StackExt s = new StackExt();

            List<int> n = new List<int>();
            foreach (var o in operations)
            {
                string[] t = o.Split(' ');
                switch (t[0])
                {
                    case "push":
                        s.Push(Convert.ToInt32(t[1]));
                        break;
                    case "pop":
                        s.Pop();
                        break;
                    case "min":
                        n.Add(s.Min);
                        break;
                }

            }
            return n.ToArray();
        }
        public class StackExt : Stack<int>
        {
            public int Min { get; set; }
            public StackExt() { this.Min = int.MaxValue; }
            public new void Push(int n)
            {
                if (Min > n)
                {
                    Min = n;
                }
                base.Push(n);
            }
            public new int Pop()
            {
                if (this.Count > 0)
                {
                    int t = base.Pop();
                    if (this.Count > 0)
                    {
                        Min = this.Min();
                    }
                    else
                    {
                        Min = int.MaxValue;
                    }
                    return t;
                }
                else
                {
                    Min = int.MaxValue;
                    return Min;
                }
            }
        }

    }
}
