using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Codility
{
    public class TestScore
    {
        public static int solution(string[] T, string[] R)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            string taskName = string.Empty;
            int s = 0;
            Dictionary<int, bool> d = new Dictionary<int, bool>();
            int c = 0;
            foreach (var item in T)
            {
                
                if (!string.IsNullOrEmpty(item))
                {
                    if (string.IsNullOrEmpty(taskName))
                    {
                        for (int i = 0; i < item.Length; i++)
                        {
                            if (!Char.IsLetter(item[i]))
                            {
                                s = i;
                                break;
                            }
                        }
                        taskName = item.Substring(0, s);
                    }
                    int tId = 0;
                    if (Char.IsLetter(item[item.Length - 1]))
                    {
                        tId = Convert.ToInt32(item.Substring(s, item.Length - (s+1)));

                    }else
                    {
                        tId = Convert.ToInt32(item.Substring(s, item.Length - s));
                    }
                    switch (R[c])
                    {
                        case "OK":
                            if (!d.ContainsKey(tId))
                            {
                                d.Add(tId,true);
                            }
                            break;
                        default:
                            if (!d.ContainsKey(tId))
                            {
                                d.Add(tId, false);
                            }else
                            {
                                d[tId] = false;
                            }
                            break;
                    }
                }
                c++;
            }

            return (int)Math.Round(100.0 * d.Where(x => x.Value.Equals(true)).Count() / d.Count,0);
        }
    }
}
