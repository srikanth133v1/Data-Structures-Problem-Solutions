using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class ShortestUniquePrefix
    {

        public static void Insert(TrieNode root, string input)
        {
            TrieNode temp = root;
            for (int i = 0; i < input.Length; i++)
            {
                int ascii = input[i];
                if (temp.children[ascii] == null)
                {
                    temp.children[ascii] = new TrieNode();
                    temp.children[ascii].frequency = 1;
                   
                }
                else
                {
                    temp.children[ascii].frequency += 1;
                }
                temp = temp.children[ascii];
            }
        }
        public static void FindAllPrefixes(TrieNode root, char[] prefixes, int index, List<string> allPrefixes)
        {
            if (root == null)
            {
                return;
            }
            if (root.frequency == 1)
            {
                prefixes[index] = '\0';
                allPrefixes.Add(new string(prefixes));
                return;
            }

            for (int i = 0; i < 256; i++)
            {
                if (root.children[i] != null)
                {
                    prefixes[index] = (char)i;
                    FindAllPrefixes(root.children[i], prefixes, index + 1, allPrefixes);
                }
            }
        }

        public static void Find(List<string> A)
        {
            TrieNode root = new TrieNode();
            root.frequency = 0;

            for (int i = 0; i < A.Count; i++)
            {
                Insert(root, A[i]);
            }
            char[] prefixes = new char[256];
            List<string> allPrefixes = new List<string>();
            FindAllPrefixes(root, prefixes, 0, allPrefixes);

            allPrefixes.Distinct();
            foreach (var item in allPrefixes)
            {
                Console.WriteLine(item);
            }
        }

    }
}
