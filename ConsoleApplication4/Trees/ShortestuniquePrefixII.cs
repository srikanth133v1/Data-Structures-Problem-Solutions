using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class ShortestuniquePrefixII
    {
        public static List<string> prefix(List<string> A)
        {
            TrieNode root = new TrieNode();
            root.frequency = 0;

            for (int i = 0; i < A.Count; i++)
            {
                Insert(root, A[i], i);
            }
            char[] prefixes = new char[26];
            List<Prefix> allPrefixes = new List<Prefix>();
            FindAllPrefixes(root, prefixes, 0, allPrefixes);

            allPrefixes.Distinct(new PrefixEqualityComparer());

          

            allPrefixes.Sort((a, b) =>
            {
                return a.Order.CompareTo(b.Order);
            });
           
            return allPrefixes.Select(i => i.Key).ToList();
        }

        public static void Insert(TrieNode root, string input, int index)
        {
            TrieNode temp = root;
            for (int i = 0; i < input.Length; i++)
            {
                int ascii = input[i] - (int)'a';
                if (temp.children[ascii] == null)
                {
                    temp.children[ascii] = new TrieNode();
                    temp.children[ascii].frequency = 1;
                    temp.children[ascii].index = index;
                }
                else
                {
                    temp.children[ascii].frequency += 1;

                }
                temp = temp.children[ascii];
            }
        }
        public static void FindAllPrefixes(TrieNode root, char[] prefixes, int index, List<Prefix> allPrefixes)
        {
            if (root == null)
            {
                return;
            }
            if (root.frequency == 1)
            {
                prefixes[index] = '\0';
                List<char> c = new List<char>();
                for (int t = 0; t< prefixes.Length&&t<index+1;t++)
                {
                    if (prefixes[t] != '\0')
                    {
                        c.Add(prefixes[t]);
                    }
                }
                
                allPrefixes.Add(new Prefix() { Key = new string(c.ToArray()), Order = root.index });
                return;
            }

            for (int i = 0; i < 26; i++)
            {
                if (root.children[i] != null)
                {
                    prefixes[index] = (char)(i + (int)'a');
                    FindAllPrefixes(root.children[i], prefixes, index + 1, allPrefixes);
                }
            }
        }

        public class Prefix
        {
            public string Key { get; set; }
            public int Order { get; set; }
        }

        public class PrefixEqualityComparer : IEqualityComparer<Prefix>
        {
            public bool Equals(Prefix x, Prefix y)
            {
                return (x.Key.Equals(y.Key));
            }

            public int GetHashCode(Prefix obj)
            {
                return obj.Key.GetHashCode();
            }
        }



    }
}
