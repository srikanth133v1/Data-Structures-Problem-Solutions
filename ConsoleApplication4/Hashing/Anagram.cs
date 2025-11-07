using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Hashing
{
    public class Anagram
    {
        public static List<List<int>> Print(List<string> A)
        {
            if (null == A || A.Count == 0)
            {
                return new List<List<int>>();
            }
            SortedDictionary<string, List<int>> s = new SortedDictionary<string, List<int>>();

            for (int i = 0; i < A.Count; i++)
            {
                char[] temp = A[i].ToCharArray();
                Array.Sort(temp);
                string current = new string(temp);
                if (!s.ContainsKey(current))
                {
                    s.Add(current, new List<int>() { i + 1 });
                }
                else
                {
                    s[current].Add(i + 1);
                }
            }
            List<List<int>> anagrams = new List<List<int>>();
            foreach (var item in s)
            {
                if (item.Value.Count > 1)
                {
                    anagrams.Add(item.Value);
                }
            }

            for (int i = 0; i < anagrams.Count; i++)
            {
                Console.WriteLine(string.Join(" ", anagrams[i].ToArray()));
            }

            return anagrams;
        }
    }
}
