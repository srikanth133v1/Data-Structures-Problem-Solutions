using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Codility
{
    public  class CropSentenc
    {
        public static string Crop(string message, int K)
        {
            K = K + 1;
            if (string.IsNullOrEmpty(message))
            {
                return message;
            }
            string temp = message.TrimEnd();
            if (string.IsNullOrEmpty(temp) || K > temp.Length)
            {
                return temp.TrimEnd();
            }

            string sub = temp.Substring(0, K);
            if(sub[sub.Length-1]==' ')
            {
                return sub.TrimEnd();
            }
            sub = sub.TrimEnd();
            int lastIndex = sub.Length - 1;
            for (int i = sub.Length-1; i >= 0; i--)
            {
                if(sub[i]==' ')
                {
                    lastIndex = i;
                    break;
                }
            }
            if (lastIndex >=0)
            {
                return sub.Substring(0, lastIndex);
            }else
            {
                return null;
            }
        }

        public static string message(string message, int K)
        {
            if (message.Length < 3) return message;
            int totalLen = 3;
            Stack<string> stack = new Stack<string>();
            String[] words = message.Split(' ');
            StringBuilder notification = new StringBuilder();

            foreach (var word in words)
            {
                int curLen = word.Length;
                totalLen += curLen + 1;
                if (totalLen <= K) stack.Push(word);
                else
                {
                    totalLen = totalLen - curLen - 1;
                    break;
                }
            }
            if (stack.Count>0)
            {
                string[] lst = stack.ToList().Reverse<string>().ToArray();
                if (message.Length < K)
                {
                    
                    return string.Join(" ", lst);
                }
                notification.Append(string.Join(" ", lst)).Append(" ...");
                return notification.ToString();
            }
            else return "...";
        }
    }
}
