using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



public class Result
{

    /*
     * Complete the 'findTotalImbalance' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts INTEGER_ARRAY rank as parameter.
     */
    public static long findTotalImbalance(List<int> rank)
    {
        if (null == rank || rank.Count == 0)
        {
            return 0;
        }
        rank = rank.Distinct().ToList();
        //rank.Sort();
        List<List<int>> s = new List<List<int>>();
        long imb = 0;
        //Generate(s, rank, new List<int>(), 0);
        for (int i = 0; i < rank.Count; i++)
        {
            List<int> t = new List<int>();
            t.Add(rank[i]);
            for (int j = i+1; j < rank.Count; j++)
            {
                t.Add(rank[j]);
                imb += CalImb(t);
            }
            
        }
        //for (var i = 0; i < s.Count; i++)
        //{
        //    Console.WriteLine(String.Join(",", s[i].ToArray()));
        //    var imbT = CalImb(s[i]);
        //    Console.WriteLine("imbT:" + imbT);
        //    imb += imbT;
        //}
        return imb;
    }
    //public static long findTotalImbalance(List<int> rank)
    //{
    //    if (null == rank || rank.Count == 0)
    //    {
    //        return 0;
    //    }
    //    rank = rank.Distinct().ToList();
    //    //rank.Sort();
    //    List<List<int>> s = new List<List<int>>();
    //    long imb = 0;
    //    Generate(s, rank, new List<int>(), 0);
    //    for (var i = 0; i < s.Count; i++)
    //    {
    //        Console.WriteLine(String.Join(",", s[i].ToArray()));
    //        var imbT = CalImb(s[i]);
    //        Console.WriteLine("imbT:" + imbT);
    //        imb += imbT;
    //    }
    //    return imb;
    //}
    public static long CalImb(List<int> sRank)
    {
        long imb = 0;
        Console.WriteLine(String.Join(",", sRank.ToArray()));
        sRank.Sort();
        if (sRank.Count <= 1)
        {
            return imb;
        }
        for (var i = 1; i < sRank.Count; i++)
        {
            if (sRank[i] - sRank[i - 1] > 1)
            {
                imb++;
            }
        }
        return imb;
    }
    public static void Generate(List<List<int>> s, List<int> d, List<int> o, int idx)
    {
        if (idx == d.Count)
        {
            s.Add(o);
            //CalImb(o);
            return;
        }
        Generate(s, d, new List<int>(o), idx + 1);
        o.Add(d[idx]);
        Generate(s, d, new List<int>(o), idx + 1);
    }
}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int rankCount = Convert.ToInt32(Console.ReadLine().Trim());

//        List<int> rank = new List<int>();

//        for (int i = 0; i < rankCount; i++)
//        {
//            int rankItem = Convert.ToInt32(Console.ReadLine().Trim());
//            rank.Add(rankItem);
//        }

//        long result = Result.findTotalImbalance(rank);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}

