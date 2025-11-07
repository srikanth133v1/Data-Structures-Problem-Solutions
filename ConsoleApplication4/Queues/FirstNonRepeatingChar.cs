using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Queues
{
    public class FirstNonRepeatingChar
    {
        public static string Build(string input)
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            Queue<char> q = new Queue<char>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (!d.ContainsKey(input[i]))
                {
                    d.Add(input[i], 1);
                    q.Enqueue(input[i]);
                }
                else
                {
                    d[input[i]]++;
                    if (q.Count > 0 && q.Peek() == input[i])
                    {
                        q.Dequeue();
                    }
                }
                if (q.Count == 0)
                {
                    sb.Append("*");
                }
                else
                {
                    sb.Append(q.Peek());
                }
            }

            return sb.ToString();
        }
    }
}
