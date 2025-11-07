using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Hashing
{
    public class HashingInvoker
    {
        public static void Invoke()
        {
            //Console.WriteLine(DiffkII.Find(new List<int>() { 3 }, 5));
            //List<int> d = _2Sum.Find(new List<int>() {1,1,1 }, 2);
            //for (int i = 0; i < d.Count; i++)
            //{
            //    Console.WriteLine(d[i]);
            //}

            //Console.WriteLine(LongestSubstringWithoutRepeat.Find("g4L8WKvi"));
            //Anagram.Print(new List<string>() { "cat", "dog", "god", "tca" });
            //Console.WriteLine(Fraction.Cal(945, 103));

            //List<int> indexes = SubstringConcatenationNew.Invoke("barfoothefoobarman", new List<string>() { "foo", "bar" });
            //Console.WriteLine(string.Join(",", indexes));

            Console.WriteLine(LongestConsecutiveSequence.Find(new List<int>() { 100, 4, 200, -1, -2, 2 }));
        }
    }
}
