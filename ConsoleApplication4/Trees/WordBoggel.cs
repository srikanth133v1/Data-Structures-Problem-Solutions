using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class WordBoggel
    {
        public class TrieNode
        {
            public TrieNode[] children = new TrieNode[26];

            public bool isEnd;
            public int index { get; set; }
        }
        public static void Insert(TrieNode root, string input)
        {

            TrieNode temp = root;
            for (int i = 0; i < input.Length; i++)
            {
                int ascii = input[i] - (int)'A';
                if (temp.children[ascii] == null)
                {
                    temp.children[ascii] = new TrieNode();
                }
                temp = temp.children[ascii];
            }
            temp.isEnd = true;
        }
        
        static int rows = 0, col = 0;
        static bool IsValid(int i, int j, bool[][] visited)
        {
            return i >= 0 && j >= 0 && i < rows && j < col && !visited[i][j];
        }
        public static string[] wordBoggel(char[][] a, string[] w)
        {
            int[] v = new int[a.Length];
            TrieNode r = new TrieNode();
            foreach (var wi in w)
            {
                Insert(r, wi);
            }
            rows = a.Length;
            col = a[0].Length;
            bool[][] visited = new bool[rows][];
            for (int i = 0; i < rows; i++)
            {
                visited[i] = new bool[col];
            }
            List<string> m = new List<string>();
            string match = string.Empty;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (r.children[a[i][j] - 'A'] != null)
                    {
                        match += a[i][j];
                        Find(i, j, visited, a, r.children[a[i][j] - 'A'], m, match);
                        match = string.Empty;
                    }

                }
            }
            //m = m.Distinct().ToList();
            //m.Sort();
            return m.ToArray();

        }
        static void Find(int i, int j, bool[][] visited, char[][] boggel, TrieNode r, List<string> m, string s)
        {
            if (r.isEnd)
            {
                //Console.WriteLine(s);
                m.Add(s);
                //return;
            }
            if (IsValid(i, j, visited))
            {
                visited[i][j] = true;
                for (int k = 0; k < 26; k++)
                {
                    if (r.children[k] != null)
                    {
                        char c = (char)(k + 'A');

                        if (IsValid(i + 1, j + 1, visited) && boggel[i + 1][j + 1] == c)
                        {
                            Find(i + 1, j + 1, visited, boggel, r.children[k], m, s + c);
                        }
                        if (IsValid(i, j + 1, visited) && boggel[i][j + 1] == c)
                        {
                            Find(i, j + 1, visited, boggel, r.children[k], m, s + c);
                        }
                        if (IsValid(i - 1, j + 1, visited) && boggel[i - 1][j + 1] == c)
                        {
                            Find(i - 1, j + 1, visited, boggel, r.children[k], m, s + c);
                        }
                        if (IsValid(i + 1, j, visited) && boggel[i + 1][j] == c)
                        {
                            Find(i + 1, j, visited, boggel, r.children[k], m, s + c);
                        }
                        if (IsValid(i + 1, j - 1, visited) && boggel[i + 1][j - 1] == c)
                        {
                            Find(i + 1, j - 1, visited, boggel, r.children[k], m, s + c);
                        }
                        if (IsValid(i, j - 1, visited) && boggel[i][j - 1] == c)
                        {
                            Find(i, j - 1, visited, boggel, r.children[k], m, s + c);
                        }
                        if (IsValid(i - 1, j - 1, visited) && boggel[i - 1][j - 1] == c)
                        {
                            Find(i - 1, j - 1, visited, boggel, r.children[k], m, s + c);
                        }

                        if (IsValid(i - 1, j, visited) && boggel[i - 1][j] == c)
                        {
                            Find(i - 1, j, visited, boggel, r.children[k], m, s + c);
                        }

                    }

                }
                visited[i][j] = false;
            }
        }
    }

}
