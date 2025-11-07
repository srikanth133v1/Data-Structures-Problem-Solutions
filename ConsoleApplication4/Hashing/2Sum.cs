using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Hashing
{
    public class _2Sum
    {
        public static List<int> Find(List<int> A, int sum)
        {
            //if (null == A || A.Count == 0)
            //{
            //    return A;
            //}

            //Dictionary<int, int> s = new Dictionary<int, int>();
            //for (int i = 0; i < A.Count; i++)
            //{
            //    if (!s.ContainsKey(A[i]))
            //    {
            //        s.Add(A[i], i);
            //    }
            //}

            //SortedDictionary<int, SortedDictionary<int, int>> sol = new SortedDictionary<int, SortedDictionary<int, int>>();

            //for (int i = 0; i < A.Count; i++)
            //{
            //    int res = sum - A[i];
            //    if (s.ContainsKey(res))
            //    {
            //        // Console.WriteLine(i + "  " + s[res]);
            //        if (i < s[res])
            //        {
            //            if (!sol.ContainsKey(s[res]))
            //            {
            //                var kp = new SortedDictionary<int, int>();
            //                kp.Add(i, s[res]);
            //                sol.Add(s[res], kp);
            //            }
            //            else
            //            {
            //                sol[res].Add(i, s[res]);
            //            }

            //        }
            //    }
            //}
            //if (sol.Count > 0)
            //{
            //    foreach (var item in sol)
            //    {
            //        if (item.Value.Values.Count > 0)
            //        {
            //            return new List<int>() { item.Value.ElementAt(0).Key + 1, item.Key + 1 };
            //            break;
            //        }
            //    }
            //}
            //return new List<int>();


            if (null == A || A.Count == 0)
            {
                return A;
            }

            Dictionary<int, SortedDictionary<int, int>> s = new Dictionary<int, SortedDictionary<int, int>>();
            for (int i = 0; i < A.Count; i++)
            {
                if (!s.ContainsKey(A[i]))
                {
                    var dict = new SortedDictionary<int, int>();
                    dict.Add(i, i);
                    s.Add(A[i], dict);
                }
                else
                {
                    s[A[i]].Add(i, i);
                }
            }

            SortedDictionary<int, SortedDictionary<int, int>> sol = new SortedDictionary<int, SortedDictionary<int, int>>();

            for (int i = 0; i < A.Count; i++)
            {
                int res = sum - A[i];
                if (s.ContainsKey(res))
                {
                    bool hasDuplicates = false;
                    int index2 = s[res].ElementAt(0).Key;
                    if (i == index2)
                    {
                        if (s[res].Values.Count > 1)
                        {
                            hasDuplicates = true;
                            index2 = s[res].ElementAt(1).Key;
                        }
                    }
                    // Console.WriteLine(i + "  " + s[res]);
                    if (i < index2 || hasDuplicates)
                    {
                        if (!sol.ContainsKey(index2))
                        {
                            var kp = new SortedDictionary<int, int>();
                            kp.Add(i, index2);
                            sol.Add(index2, kp);
                        }
                        else
                        {
                            sol[index2].Add(i, index2);
                        }

                    }

                }
            }
            if (sol.Count > 0)
            {
                foreach (var item in sol)
                {
                    if (item.Value.Values.Count > 0)
                    {
                        return new List<int>() { item.Value.ElementAt(0).Key + 1, item.Key + 1 };
                        break;
                    }
                }
            }
            return new List<int>();
        }
    }
}
