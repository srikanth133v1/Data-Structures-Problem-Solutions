using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System;

class HotelReviewsII
{
    public List<int> solve(string A, List<string> B)
    {
        return BuildTrie(B, A);
    }

    public static List<int> BuildTrie(List<string> lstInputs, string good)
    {
        if (null == lstInputs || lstInputs.Count > 200)
        {
            return null;
        }
        string[] goodWords = good.Split(new string[] { "_" }, StringSplitOptions.RemoveEmptyEntries);
        goodWords = goodWords.Distinct().ToArray();

        TrieNode root = new TrieNode();
        foreach (var goodWord in goodWords)
        {
            if (goodWord.Length > 4)
            {
                continue;
            }
            Insert(root, goodWord);
        }

        List<Review> reviews = new List<Review>();
        for (int item = 0; item < lstInputs.Count; item++)
        {
            if (lstInputs[item].Length > 10000)
            {
                continue;
            }
            int matches = 0;
            var inputWords = lstInputs[item].Split(new string[] { "_" }, StringSplitOptions.RemoveEmptyEntries);
            //inputWords = inputWords.Distinct().ToArray();
            foreach (var inputWord in inputWords)
            {
                var res = FindString(root, inputWord);
                if (res)
                {
                    matches++;
                }
                //Console.WriteLine(inputWord + " res: "+ res);
            }

            reviews.Add(new Review()
            {
                ReviewStringIndex = item,
                GoodWordCount = matches//,
                                       //GoodWordPositions = positioms
            });
        }
        reviews.Sort(new ReviewComparer());
        return reviews.Select(x => x.ReviewStringIndex).ToList();
    }

    public static void Insert(TrieNode root, string input)
    {

        TrieNode temp = root;
        for (int i = 0; i < input.Length; i++)
        {
            int ascii = input[i] - (int)'a';
            if (temp.children[ascii] == null)
            {
                temp.children[ascii] = new TrieNode();
            }
            temp = temp.children[ascii];
        }
        temp.isEnd = true;
    }
    public static bool FindString(TrieNode root, string input)
    {
        TrieNode temp = root;

        int wordLength = 0;
        int i = 0;
        for (; i < input.Length; i++)
        {
            int val = input[i];
            val -= (int)'a';
            wordLength++;

            if (val < 0 || val > 25 || temp == null || temp.children[val] == null)
            {
                return false;
            }
            else
            {
                temp = temp.children[val];
            }
        }
        if (temp != null && temp.isEnd == true)
        {
            return true;
        }
        return false;
    }
    public class TrieNode
    {
        public TrieNode[] children = new TrieNode[26];

        public bool isEnd;
        public int index { get; set; }
    }
    public class ReviewComparer : IComparer<Review>
    {
        public int Compare(Review x, Review y)
        {
            if (x.GoodWordCount == y.GoodWordCount)
            {
                if (x.ReviewStringIndex < y.ReviewStringIndex)
                {
                    return -1;
                }
                else if (x.ReviewStringIndex > y.ReviewStringIndex)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else if (x.GoodWordCount > y.GoodWordCount)
            {
                return -1;
            }
            else
            {
                return 1;
            }

        }
    }
    public class Review
    {
        public int ReviewStringIndex { get; set; }
        public int GoodWordCount { get; set; }

    }

}
