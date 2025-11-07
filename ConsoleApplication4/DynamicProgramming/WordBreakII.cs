using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.DynamicProgramming
{
    public class WordBreakII
    {
        public static List<string> Cal(string A, List<string> B)
        {
            int startIndex = 0;
            List<string> matches = new List<string>();
            for (int i = 0; i < B.Count; i++)
            {
                List<string> match = new List<string>();
                for (int j = i; j < B.Count; j++)
                {
                    var word = B[j];
                    int endIndex = GetLastIndexOfPrefix(A.Substring(startIndex), startIndex, word);
                    if (startIndex == endIndex)
                    {
                        continue;
                    }
                    match.Add(B[j]);
                    startIndex = endIndex;
                }
                startIndex = 0;
                if (match.Count > 0)
                {
                    matches.Add(string.Join(" ", match));
                }
            }
            return matches.Distinct().ToList();
        }

        public static int GetLastIndexOfPrefix(string input, int startIndex, string word)
        {
            int endIndex = startIndex;
            if (input.StartsWith(word))
            {
                endIndex = startIndex + word.Length;

            }
            return endIndex;
        }
    }
}
