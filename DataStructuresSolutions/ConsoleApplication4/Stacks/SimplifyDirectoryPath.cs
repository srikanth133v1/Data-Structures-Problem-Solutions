using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Stacks
{
    public class SimplifyDirectoryPath
    {
        public static string Eval(string A)
        {
            if (string.IsNullOrEmpty(A) || string.IsNullOrEmpty(A.Trim()))
            {
                return A;
            }
            A = A.Trim();
            string[] tokens = A.Split(new string[] { @"/" }, StringSplitOptions.RemoveEmptyEntries);
            Stack<string> s = new Stack<string>();

            for (int i = 0; i < tokens.Length; i++)
            {
                string currentToken = tokens[i].Trim();
                if (currentToken == "..")
                {
                    if (s.Peek() != ".." && s.Count > 0)
                    {
                        s.Pop();
                    }
                    else
                    {
                        s.Push(currentToken);
                    }
                }
                else if (currentToken == ".")
                {
                    continue;
                }
                else
                {

                    s.Push(currentToken);
                }
            }

            List<string> finalTokens = new List<string>();
            while (s.Count > 0)
            {
                finalTokens.Add(s.Pop());
            }
            finalTokens.Reverse();

            return "/" + string.Join("/", finalTokens.ToArray());
        }
    }
}
