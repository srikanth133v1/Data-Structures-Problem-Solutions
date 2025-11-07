using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.CodeFights
{
    public class TextJustification
    {
        public static string textJustification(string[] words, int length)
        {
            StringBuilder sb = new StringBuilder();
            for (var i = 0; i < words.Length; i++)
            {
                int count = words[i].Length;
                List<string> t = new List<string>();
                t.Add(words[i]);
                count++;
                while (i + 1 < words.Length && count + words[i + 1].Length <= length)
                {
                    if (count + words[i + 1].Length + 1 <= length)
                    {
                        i++;
                        count++;
                        count += words[i].Length;
                        t.Add(words[i]);
                    }
                }

                if (t.Count > 1)
                {
                    int bal = length - count + t.Count;
                    int extra = bal / (t.Count - 1);
                    int rem = bal % (t.Count - 1);
                    //Console.WriteLine($"length: {length},  bal:{bal} , extra : {extra} , rem: {rem} ");
                    for (int idx = 0; idx < t.Count - 1; idx++)
                    {
                        sb.Append(t[idx]);
                        for (int j = 0; j < extra; j++)
                        {
                            sb.Append(" ");
                        }

                        if (rem > 0)
                        {
                            sb.Append(" ");
                            rem--;
                        }
                    }

                    sb.Append(t[t.Count - 1]);
                    while (rem > 0)
                    {
                        sb.Append(" ");
                        rem--;
                    }
                }
                else
                {
                    sb.Append(t[t.Count - 1]);
                    int temp = length - t[t.Count - 1].Length;
                    //Console.WriteLine($"temp:{temp}");
                    while (temp > 0)
                    {
                        sb.Append(" ");
                        temp--;
                    }
                }
                sb.Append("\n");

            }

            return sb.ToString();
        }

        string[] textJustification1(string[] words, int length)
        {
            List<string> res = new List<string>();
            for (var i = 0; i < words.Length; i++)
            {
                StringBuilder sb = new StringBuilder();

                int count = words[i].Length;
                List<string> t = new List<string>();
                t.Add(words[i]);
                count++;
                while (i + 1 < words.Length && count + words[i + 1].Length <= length)
                {
                    if (count + words[i + 1].Length <= length)
                    {
                        i++;
                        count++;
                        count += words[i].Length;
                        t.Add(words[i]);
                    }
                    else
                    {
                        count--;
                        break;
                    }
                }

                if (t.Count > 1)
                {
                    if (i == words.Length - 1)
                    {
                        for (int idx = 0; idx < t.Count - 1; idx++)
                        {
                            sb.Append(t[idx]).Append(" ");
                        }


                        sb.Append(t[t.Count - 1]);
                        int temp = length - sb.Length;
                        Console.WriteLine("sb length: " + sb.Length + " , temp: " + temp);
                        while (temp > 0)
                        {
                            sb.Append(" ");
                            Console.WriteLine("temp: " + temp);
                            temp--;
                        }
                    }
                    else
                    {


                        Console.WriteLine("i: " + i);
                        int bal = length - count + t.Count;
                        int extra = bal / (t.Count - 1);
                        int rem = bal % (t.Count - 1);
                        //Console.WriteLine($"length: {length},  bal:{bal} , extra : {extra} , rem: {rem} ");
                        for (int idx = 0; idx < t.Count - 1; idx++)
                        {
                            sb.Append(t[idx]);
                            for (int j = 0; j < extra; j++)
                            {
                                sb.Append(" ");
                            }

                            if (rem > 0)
                            {
                                sb.Append(" ");
                                rem--;
                            }
                        }

                        sb.Append(t[t.Count - 1]);
                        while (rem > 0)
                        {
                            sb.Append(" ");
                            rem--;
                        }
                    }
                }
                else
                {
                    sb.Append(t[t.Count - 1]);
                    int temp = length - t[t.Count - 1].Length;
                    //Console.WriteLine($"temp:{temp}");
                    while (temp > 0)
                    {
                        sb.Append(" ");
                        temp--;
                    }
                }
                res.Add(sb.ToString());

            }

            return res.ToArray();
        }


    }


}
