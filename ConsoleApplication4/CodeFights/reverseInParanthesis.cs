using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.CodeFights
{
    public class ReverseInParanthesis
    {
        public static string Invoke(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }
            char[] input = text.ToCharArray();
            Stack<char> s = new Stack<char>();
            StringBuilder sb = new StringBuilder();
            bool hasP = false;
            for (var i = 0; i < input.Length; i++)
            {

                if (input[i] == '(')
                {
                    hasP = true;
                }
                else if (input[i] == ')')
                {
                    while (s.Count > 0)
                    {
                        sb.Append(s.Pop());
                    }
                }
                else if (!hasP)
                {
                    sb.Append(input[i]);
                }
                else if (hasP)
                {
                    s.Push(input[i]);
                }
            }
            return sb.ToString();
        }

        public static void Reverse(int startIndex, int endIndex, char[] input)
        {
            while (startIndex < endIndex)
            {
                char t = input[startIndex];
                input[startIndex] = input[endIndex];
                input[endIndex] = t;
                startIndex++;
                endIndex--;
            }
            //return input;
        }
    }
}
