using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class HotelReviews
    {
        //Build the trie of each string with index of each string
        public static List<string> BuildTrie(List<string> lstInputs, string goodWords)
        {
            if (null == lstInputs || lstInputs.Count > 200)
            {
                return null;
            }

            List<Review> reviews = new List<Review>();
            foreach (var item in lstInputs)
            {
                TrieNode root = new TrieNode();
                Insert(root, item);
                int matches = 0;
                var positioms = FindString(root, goodWords, out matches);
                reviews.Add(new Review()
                {
                    ReviewString = item,
                    GoodWordCount = matches,
                    GoodWordPositions = positioms
                });
            }
            reviews.Sort(new ReviewComparer());

            return reviews.Select(x => x.ReviewString).ToList();
        }
        //find number of goodwords in each string and calculate total weight, good word count
        //sort by desc number of goodwords with 
        //build the trie of good words with weight (order) assigned to each word
        public static void Insert(TrieNode root, string input)
        {
            if (input.Length > 10000)
            {
                return;
            }
            TrieNode temp = root;
            int wordCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int val = input[i] - (int)'a';
                if (input[i] == '_')
                {
                    temp = root;
                    wordCount++;
                    if (wordCount > 1000)
                    {
                        return;
                    }
                }
                else
                {
                    if (val < 0)
                    {
                        return;
                    }
                    if (temp.children[val] == null)
                    {
                        temp.children[val] = new TrieNode();
                        temp.children[val].frequency = 1;
                        temp.index = wordCount;
                    }
                    else
                    {
                        temp.children[val].frequency += 1;
                    }

                    temp = temp.children[val];
                }
            }
        }

        public static List<bool> FindString(TrieNode root, string goodWord, out int matches)
        {
            TrieNode temp = root;
            matches = 0;
            List<bool> checks = new List<bool>();
            int goodWordCount = 0;
            int wordLength = 0;
            for (int i = 0; i < goodWord.Length; i++)
            {
                int val = goodWord[i];

                if (val == '_')
                {
                    wordLength = 0;
                    if (temp != null && temp.frequency == 1)
                    {
                        temp = root;
                        checks.Add(true);
                        matches++;
                    }
                    goodWordCount++;
                    if (goodWordCount > 10000)
                    {
                        return null;
                    }
                }
                else
                {
                    val -= (int)'a';
                    wordLength++;
                    if (wordLength > 4)
                    {
                        return null;
                    }
                    if (temp == null)
                    {
                        break;
                    }
                    if (temp.children[val] == null)
                    {
                        checks.Add(false);
                        while (i < goodWord.Length)
                        {
                            char c = goodWord[i];
                            if (c == '_')
                            {
                                temp = root;
                                goodWordCount++;
                                wordLength = 0;
                                break;
                            }
                            i = i + 1;
                        }
                    }
                    else
                    {
                        temp = temp.children[val];
                    }

                }
            }
            if (temp != null && temp.frequency == 1 && checks.Count <= goodWordCount)
            {
                checks.Add(true);
            }
            return checks;
        }
        public class ReviewComparer : IComparer<Review>
        {
            public int Compare(Review x, Review y)
            {
                if (x.GoodWordCount != y.GoodWordCount)
                {
                    return x.GoodWordCount > y.GoodWordCount ? -1 : 1;
                }
                else
                {
                    for (int i = 0; i < x.GoodWordPositions.Count; i++)
                    {
                        if (x.GoodWordPositions[i] != y.GoodWordPositions[i])
                        {
                            return (x.GoodWordPositions[i] == true) ? -1 : 1;
                        }
                    }
                }
                return 0;
            }
        }
        public class Review
        {
            public string ReviewString { get; set; }
            public int GoodWordCount { get; set; }

            public List<bool> GoodWordPositions { get; set; }
        }

    }


}
