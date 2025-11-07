using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication4.Hashing
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    class SubstringConcatenationNew
    {
        public List<int> findSubstring(string A, List<string> B)
        {
            if (string.IsNullOrEmpty(A) || null == B || B.Count == 0)
            {
                return new List<int>();
            }

            return Invoke(A, B);
        }
        public static void Collect(string A, List<string> data, Dictionary<int, int> indexes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in data)
            {
                sb.Append(item);
            }
            Find(A, sb.ToString(), indexes);
        }

        public static void Generate(List<string> A, string S, int size, Dictionary<int, int> indexes)
        {
            if (size == 1)
            {
                Collect(S, A, indexes);
                return;

            }

            for (int i = 0; i < size; i++)
            {
                Generate(A, S, size - 1, indexes);

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

        public static void Find(string A, string item, Dictionary<int, int> indexes)
        {
            if (A.Contains(item))
            {
                Console.WriteLine(item);
                for (int i = 0; i < A.Length; i++)
                {
                    int index = A.IndexOf(item, i);
                    if (index == -1)
                    {
                        break;
                    }
                    if (!indexes.ContainsKey(index))
                    {
                        indexes.Add(index, index);
                    }

                }
            }
        }

        public static List<int> Invoke(string A, List<string> B)
        {
            List<string> comb = new List<string>();
            Dictionary<int, int> indexesDict = new Dictionary<int, int>();
            Generate(B, A,  B.Count, indexesDict);

            List<int> indexes = new List<int>();
            indexes = indexesDict.Values.Distinct().ToList();
            indexes.Sort();
            return indexes;
        }
    }

}
