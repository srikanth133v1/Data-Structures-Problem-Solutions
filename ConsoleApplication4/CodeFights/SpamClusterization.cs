using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication4.CodeFights
{
    public class SpamClusterization
    {
        int[][] spamClusterization(string[] requests, int[] ids, double threshold)
        {
            List<List<string>> reqs = new List<List<string>>();
            for (int i = 0; i < requests.Length; i++)
            {
                reqs.Add(GetSet(requests[i]));
            }
            Dictionary<double, SortedDictionary<int, int>> d = new Dictionary<double, SortedDictionary<int, int>>();
            for (int i = 0; i < reqs.Count; i++)
            {
                for (int j = i + 1; j < reqs.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (reqs[i].Count > 0 && reqs[j].Count > 0)
                    {


                        var ji = JaccardIndex(reqs[i], reqs[j]);
                        Console.WriteLine("ji :" + ji + " ,i: " + i + " j: " + j);
                        if (ji >= threshold)
                        {
                            if (!d.ContainsKey(ji))
                            {
                                var entries = new SortedDictionary<int, int>();
                                entries.Add(ids[i], ids[i]);
                                if (!entries.ContainsKey(ids[j]))
                                {
                                    entries.Add(ids[j], ids[j]);
                                }

                                d.Add(ji, entries);
                            }
                            else
                            {
                                if (!d[ji].ContainsKey(ids[i]))
                                {
                                    d[ji].Add(ids[i], ids[i]);
                                }
                                if (!d[ji].ContainsKey(ids[j]))
                                {
                                    d[ji].Add(ids[j], ids[j]);
                                }

                            }
                        }
                    }
                }
            }


            SortedDictionary<int, int[]> v = new SortedDictionary<int, int[]>();
            foreach (var de in d)
            {
                if (de.Value.Values.Count() > 1)
                {
                    var tmp = de.Value.Values.ToList();
                    tmp.Sort();
                    if (!v.ContainsKey(tmp[0]))
                    {
                        v.Add(tmp[0], tmp.ToArray());
                    }
                    else
                    {
                        var t2 = v[tmp[0]];
                        var t3 = t2.ToList();
                        t3.AddRange(tmp);
                        t3.Sort();
                        v[tmp[0]] = t3.ToArray();
                    }
                    //Console.WriteLine(string.Join(", ", tmp.ToArray()));
                }
            }

            return v.Values.ToArray();
        }
        List<string> GetSet(string req)
        {
            if (string.IsNullOrEmpty(req) || req.Length > 65)
            {
                return new List<string>();
            }
            req = req.ToLower();
            Dictionary<string, string> d = new Dictionary<string, string>();
            var res = Regex.Matches(req, @"([a-zA-Z-_0-9])\w*");
            if (null != res)
            {
                foreach (Match item in res)
                {
                    if (!string.IsNullOrEmpty(item.Value))
                    {
                        if (!d.ContainsKey(item.Value))
                        {
                            d.Add(item.Value, item.Value);
                        }
                    }
                }
            }

            //Console.WriteLine(string.Join(", ", d.Values.ToArray()));
            return d.Values.ToList();
        }
        double JaccardIndex(List<string> x, List<string> y)
        {
            var intersection = (from a in x
                                join b in y on a equals b
                                select a).ToList();
            var intersectCount = intersection.Count;
            var union = (x.Count + y.Count) - intersectCount;
            if (union > 0 && intersectCount > 0)
            {
                return Math.Round((double)((double)intersectCount / (double)union), 1);
            }
            else
            {
                return 0;
            }
            //Console.WriteLine("union: "+ union.Count()+ " , inter: "+ intersection.Count());

        }
    }
}
