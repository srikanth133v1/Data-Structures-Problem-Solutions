using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Stacks
{
    public class ReverseString
    {
        public static void Reverse(string A)
        {
            StringBuilder sb = new StringBuilder();
            Stack<char> s = new Stack<char>();

            for (int i = 0; i < A.Length; i++)
            {
                s.Push(A[i]);
            }
            while (s.Count > 0)
            {
                sb.Append(s.Pop());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
