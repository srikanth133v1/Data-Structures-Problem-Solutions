using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Stacks
{
    public class CheckBalancedParentheses
    {
        public static int Check(string A)
        {
            Stack<char> s = new Stack<char>();
            char lastOpen = ' ';
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == '(' || A[i] == '{' || A[i] == '[')
                {
                    lastOpen = A[i];
                    s.Push(A[i]);
                }
                else if (A[i] == ')' || A[i] == '}' || A[i] == ']')
                {
                    char opening = ' ';
                    switch (A[i])
                    {
                        case ')':
                            opening = '(';
                            break;
                        case '}':
                            opening = '{';
                            break;
                        case ']':
                            opening = '[';
                            break;
                    }
                    if (lastOpen != ' ' && lastOpen == opening)
                    {
                        if (s.Count > 0)
                        {
                            s.Pop();
                            lastOpen = s.Count == 0 ? ' ' : s.Peek();
                        }

                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }

            if (s.Count == 0)
            {
                return 1;
            }
            return 0;
        }
    }
}
