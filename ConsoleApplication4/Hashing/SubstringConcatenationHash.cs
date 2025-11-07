using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication4.Hashing
{
    public class SubstringConcatenationHash
    {
        public static int CalHash(string s)
        {
            int hash = 0;
            for (int i = 0; i < s.Length; i++)
            {
                hash = (hash * 100 + s[i]) % 9999997;
            }
            return hash;
        }

        public static bool Solve(string s, int j, List<string> B)
        {
            int wsize = B[0].Length;

            for (int i = 0; i < B.Count; i++)
            {
                var str = s.Substring(j + i * wsize, wsize);
                if (B.Find(x => x == str) == B[B.Count - 1])
                {
                    return false;
                }
                B.Remove(B.Find(x => x == str));
            }
            return true;
        }
        public static List<int> FindSubString(string S, List<string> L)
        {
            List<int> ret = new List<int>();
            if (L.Count == 0)
            {
                return ret;

            }
            int hashSum = 0;
            for (int i = 0; i < L.Count; i++)
            {
                hashSum += CalHash(L[i]);

            }
            int wsize = L[0].Length, lSize = L.Count;

            for (int i = 0; i < wsize; i++)
            {
                List<int> hashes = new List<int>();
                int hashSum2 = 0;

                for (int j = i; j < S.Length; j += j + wsize)
                {
                    if (j + wsize < S.Length)
                    {
                        hashes.Add(CalHash(S.Substring(j, wsize)));
                    }
                }
                Console.WriteLine(hashes.Count);
                if (hashes.Count < lSize)
                {
                    continue;
                }
                for (int j = 0; j < lSize; j++)
                {
                    hashSum2 += hashes[j];
                }
                if (hashSum == hashSum2)
                {
                    ret.Add(i);
                }
                for (int j = lSize; j < hashes.Count; j++)
                {
                    hashSum2 = hashSum2 - hashes[j - lSize] + hashes[j];
                    if (hashSum == hashSum2)
                    {
                        ret.Add(i + (j - lSize + 1) * wsize);
                    }

                }
            }
            
            List<int> ret2 = new List<int>();
            List<string> Lset = new List<string>(L);

            for (int i = 0; i < ret.Count; i++)
            {
                if (Solve(S, ret[i], Lset))
                    ret2.Add(ret[i]);
            }

            return ret2;

        }

        public static void Collect(List<string> data, Dictionary<string, string> comb)
        {
            data.Distinct();
            var joined = string.Join("", data);
            if (!comb.ContainsKey(joined))
            {
                comb.Add(joined, joined);
            }

        }

        public static void Generate(List<string> A, int size, Dictionary<string, string> comb)
        {
            if (size == 1)
            {
                Collect(A, comb);
                return;

            }

            for (int i = 0; i < size; i++)
            {
                Generate(A, size - 1, comb);

                if (size % 2 == 1)
                {
                    string temp = A[size - 1];
                    A[size - 1] = A[0];
                    A[0] = temp;
                }
                else
                {
                    string temp = A[size - 1];
                    A[size - 1] = A[i];
                    A[i] = temp;
                }
            }
        }

        public static List<int> Find(string A, List<string> perm)
        {
            List<int> indexes = new List<int>();
            foreach (var item in perm)
            {
                if (A.Contains(item))
                {
                    for (int i = 0; i < A.Length; i++)
                    {
                        int index = A.IndexOf(item, i);
                        if (index == -1)
                        {
                            break;
                        }
                        indexes.Add(index);
                    }
                }
            }
            return indexes;
        }

        public static void Invoke()
        {
            //string[] data = new string[2];
            //Dictionary<string, string> comb = new Dictionary<string, string>();
            //SubstringConcatenation.Generate(new List<string>() { "cabccbbbc", "abbccabbc", "bbbcbbbaa", "acbaabcab", "ccacabccb", "bbacaabca", "acacbaacb", "aabbcccab", "ccccbbcaa", "baaccaabc" }, 10, comb);
            //Console.WriteLine(comb.Count);
            //foreach (var item in comb)
            //{
            //    //  Console.WriteLine(item);
            //}

            //List<int> indexes = SubstringConcatenation.Find("acaaacbcbccbaabaccabcbbcaaccbbbbcbabaacbbcbccababb", comb.Values.ToList());
            //indexes.Sort();
            //List<int> indexes = FindSubString("acaaacbcbccbaabaccabcbbcaaccbbbbcbabaacbbcbccababb", new List<string>() { "cabccbbbc", "abbccabbc", "bbbcbbbaa", "acbaabcab", "ccacabccb", "bbacaabca", "acacbaacb", "aabbcccab", "ccccbbcaa", "baaccaabc" });
            List<int> indexes = FindSubString("barfoothefoobarman", new List<string>() { "foo", "bar" });
            Console.WriteLine(string.Join(",", indexes));
        }
    }
}
