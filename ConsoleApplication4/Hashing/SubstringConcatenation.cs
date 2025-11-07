using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication4.Hashing
{
    public class SubstringConcatenation
    {
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
            string[] data = new string[2];
            Dictionary<string, string> comb = new Dictionary<string, string>();
            SubstringConcatenation.Generate(new List<string>() { "cabccbbbc", "abbccabbc", "bbbcbbbaa", "acbaabcab", "ccacabccb", "bbacaabca", "acacbaacb", "aabbcccab", "ccccbbcaa", "baaccaabc" }, 10, comb);
            Console.WriteLine(comb.Count);
            foreach (var item in comb)
            {
                //  Console.WriteLine(item);
            }

            List<int> indexes = SubstringConcatenation.Find("acaaacbcbccbaabaccabcbbcaaccbbbbcbabaacbbcbccababb", comb.Values.ToList());
            indexes.Sort();
            Console.WriteLine(string.Join(",", indexes));
        }
    }
}
