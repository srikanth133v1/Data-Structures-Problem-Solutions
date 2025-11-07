using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Stacks
{
    public class EvaluateExpression
    {
        public static int Eval(List<string> A)
        {
            if (null == A || A.Count == 0)
            {
                return 0;
            }
            Stack<int> s = new Stack<int>();

            for (int i = 0; i < A.Count; i++)
            {
                //+, -, *, /
                switch (A[i])
                {
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        int right = s.Pop();
                        int left = s.Pop();
                        s.Push(Cal(A[i], left, right));
                        break;
                    default:

                        s.Push(Int32.Parse(A[i]));
                        break;
                }
            }
            return s.Pop();
        }
        public static int Cal(string op, int l, int r)
        {
            switch (op)
            {
                case "+":
                    return l + r;
                case "-":
                    return l - r;
                case "*":
                    return l * r;
                case "/":
                    return l / r;
            }
            return 0;
        }

        public static int CalHelper(string[] ops)
        {
            Stack<int> s = new Stack<int>();
            for (int i = 0; i < ops.Length; i++)
            {
                if (ops[i] == "+")
                {
                    int l = s.Pop();
                    int r = s.Pop();
                    s.Push(l);
                    s.Push(r);
                    s.Push(l + r);
                }
                else if (ops[i] == "C")
                {
                    s.Pop();
                }else if (ops[i] == "D")
                {
                    int l = s.Pop();
                    s.Push(l);
                    s.Push(l * 2);
                }
                else if (Char.IsDigit(Convert.ToChar(ops[i])))
                {
                    s.Push(Convert.ToInt32(ops[i]));
                }
            }
            int sum = 0;
            if (s.Count > 0)
            {
                while (s.Count > 0)
                {
                    sum += s.Pop();
                }
            }
            return sum;
        }
    }
}

