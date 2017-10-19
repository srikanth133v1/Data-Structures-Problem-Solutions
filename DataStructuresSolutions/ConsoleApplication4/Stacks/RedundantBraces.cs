using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Stacks
{
    public class RedundantBraces
    {
        public static int Find(string A)
        {
            Stack<char> s = new Stack<char>();
            for (int i = 0; i < A.Length; ++i)
            {

                if (A[i] == ')')
                {

                    int cnt = 0;

                    while (s.Peek() != '(')
                    {
                        s.Pop();
                        cnt++;
                    }

                    s.Pop();
                    if (cnt < 2)
                    {
                        return 1;
                    }

                }

                else
                {
                    s.Push(A[i]);
                }

            }

            bool isExists = true;

            while (s.Count > 0)
            {

                if (s.Peek() == '(' || s.Peek() == ')')
                {

                    isExists = false;
                    break;
                }
                s.Pop();
            }

            if (!isExists)
            {
                return 1;
            }
            return 0;
        }
    }
}
