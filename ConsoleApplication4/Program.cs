using ConsoleApplication4;
using ConsoleApplication4.Backtracking;
using ConsoleApplication4.Codility;
using ConsoleApplication4.DynamicProgramming;
using ConsoleApplication4.Hashing;
using ConsoleApplication4.LinkedLists;
using ConsoleApplication4.Mathh;
using ConsoleApplication4.Problems;
using ConsoleApplication4.Queues;
using ConsoleApplication4.Stacks;
using ConsoleApplication4.Strings;
using ConsoleApplication4.Trees;
using ConsoleApplication4.TwoPointers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication4
{

    class Program
    {
        class A
        {
            public virtual void demo() { }

        }
        class B : A
        {
            public override void demo()
            {
                base.demo();
            }
            public void sample() { }
        }
        public static int Sol(string d, string n)
        {
            int s = 0;
            for (int j = 0; j < n.Length; j++)
            {
                for (int i = 0; i < d.Length; i++)
                {
                    if (n[j] == d[i])
                    {
                        if (i == 0)
                        {
                            s += 1;
                        }
                        s += i;
                        break;
                    }
                }
            }
            return s;
        }
        static int CalPoints(string[] ops)
        {
            List<int> l = new List<int>();
            for (int i = 0; i < ops.Length; i++)
            {
                switch (ops[i])
                {
                    case "+":
                        l.Add(l[l.Count - 1] + l[l.Count - 2]);
                        break;
                    case "D":
                        l.Add(2 * l[l.Count - 1]);
                        break;
                    case "C":
                        l.RemoveAt(l.Count - 1);
                        break;
                    default:
                        l.Add(Convert.ToInt32(ops[i]));
                        break;
                }

            }
            int s = 0;
            for (int j = 0; j < l.Count; j++)
            {
                s += l[j];
            }
            return s;
        }
        static DateTime d;
        static String s;
        static void Main(string[] args)
        {
            try
            {
                //TreeInvoker.Invoke();
                //QueueInvoker.Invoke();

                Console.WriteLine(Codility.CropSentenc.Crop("Codility we test coders", 14));
                Console.WriteLine(Codility.CropSentenc.Crop("The quick brown fox jumps over the lazy dog", 39));

                return;

                //List<List<int>> c = new List<List<int>>();
                //Console.WriteLine( Result.findTotalImbalance(new List<int>() { 4, 1, 3, 2 })) 

                Console.WriteLine(MaxSumSubArray.Find(new List<int>() { 904, 40, 523, 12, -335, -385, -124, 481, -31 }));

                //Console.WriteLine(ColumnMajorStr.ColMajor(new string[] { "hello", "rem", "demo" }));

                //bool[] res = Codewriting.Solution(new int[] { 8, 5, 6, 16, 5 }, 1, 3);
                //Console.WriteLine(string.Join(",", res));

                //int[] r = FirstLast.Solution(new int[] { 1, 3, 5, 6, 4, 2 });
                //Console.WriteLine(string.Join(",", r));
                //Console.WriteLine(CalPoints(new string[] { "5","2","C","D","+"}));
                //return;

                //var r= Codility.PSet.maxSetSize(new List<int>() { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 });
                // Console.WriteLine(r);
                // return;
                //Console.WriteLine(TestScore.solution(new string[]{ "test1a", "test2", "test1b", "test1c", "test3"}, new string[] { "Wrong answer", "OK", "Runtime error", "OK", "Time limit exceeded"}));

                //return;
                //Console.WriteLine(Sol("0123456789","210"));
                //    return;

                //StackInvoker.Invoke();
                //return;

                //Console.WriteLine(Codility.CropSentenc.Crop("Codility we test coders", 14));
                //Console.WriteLine(Codility.CropSentenc.Crop("The quick brown fox jumps over the lazy dog", 39));
                //Console.WriteLine(Codility.PeopleCars.Solution(new int[]{1,4,1 }, new int[]{1,5,1 }));
                //Console.WriteLine(Codility.PeopleCars.Solution(new int[] { 4, 4, 2,4 }, new int[] { 5, 5, 2,5 }));
                //Console.WriteLine(Codility.PeopleCars.Solution(new int[] { 2,3,4,2 }, new int[] { 2,5,7,2 }));
                Console.WriteLine(Codility.Pollution.Solution(new int[] { 5, 19, 8, 1 }));
                return;
                Console.WriteLine(Codility.CropSentenc.Crop("To crop or not to crop", 21));
                return;
                var toAdd = "abc@demo.com;sri@demo.com,123@qaz.com";
                string[] mailTo = toAdd.Split(new string[] { ";", "," },
                                StringSplitOptions.RemoveEmptyEntries);

                foreach (var to in mailTo)
                {
                    Console.WriteLine(to.Trim());
                }

                return;
                //Console.WriteLine(Math.Pow(2, 30));
                //Console.WriteLine((-1000 & 1073741824) - 73741817);
                //Console.WriteLine(Math.Pow(2, 30)-1000000007);
                //SortedDictionary<int, int> d = new SortedDictionary<int, int>();
                //d.Add(0, 0);
                //Console.WriteLine(Regex.Match("@".ToLower(), @"([a-zA-Z0-9])\w*").Value);
                //Console.WriteLine(Math.Round((double)2/(double)3,2));
                CodeFights.CodeFightsInvoker.Invoke();
                Console.WriteLine(reverseParentheses("foo(bar(baz))blim"));
                //Backtracking.BacktrackingInvoker.Invoke();
                //TreeInvoker.Invoke();
                return;

                //string str = "ddede";
                //Console.WriteLine(str.LastIndexOf('.'));
                //Console.WriteLine(str.Substring(-1));
                //int[][] jagged = new int[3][];
                //List <int> a = new List<int>();
                //a.Add(1);

                //List<int> b = new List<int>();
                //b.Add(1);
                //b.Add(2);

                //Console.WriteLine(a==b);

                //Console.WriteLine(s==null);
                //Console.WriteLine(d.ToString());
                //{
                //    int[] r = changeRoot(new int[] { 0, 0, 0, 1, 1, 1, 2, 2, 7 }, 7);

                //    foreach (var item in r)
                //    {
                //        Console.Write(item + "  ");
                //    }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return;

            //int[] r = constructArray(2);
            //foreach (var item in r)
            //{
            //    Console.WriteLine(item);
            //}
            //return;
            //Console.WriteLine(decodeString("4[ab]"));
            //Console.WriteLine(decodeString("2[b3[a]]"));
            //Console.WriteLine(decodeString("z1[y]zzz2[abc]"));
            //return;
            //Console.WriteLine(isLucky(0));
            //return;
            //int[] res = findDeepest("(2 (7 (2 () ()) (6 (5 () ()) (11 () ()))) (5 () (9 (4 () ()) ())))");
            //for (int i = 0; i < res.Length; i++)
            //{
            //    Console.WriteLine(res[i]);
            //}
            //return;
            //solve(new List<int>() { 1, 3, 5, 4 }, 3, 5);
            //plusOne(new List<int>() { 1, 1, 1, 3, 2, 1, 1, 2, 5, 9, 6, 5 });
            //plusOne(new List<int>() { 2, 5, 6, 8, 6, 1, 2, 4, 5 });
            // MaxSubArray(new List<int>() { 6, 0, -6, -4, 8, -8, 1 });
            // LargestNum(new List<int>() { 3, 30, 34, 5, 9 });
            //Console.WriteLine(RepeatedNumberNBy3(new List<int>() { 1, 1, 1, 3, 2, 1, 1, 2, 5, 9, 6, 5 }));
            //Console.WriteLine(ExcelColumn("AB"));
            //Console.WriteLine(ExcelColumnTitle(943566));
            //ReArrange(new int[] { 1, 2, 4, 0, 3 });
            //Console.WriteLine(TrialingZeros(26));

            //Console.WriteLine(Permutations("DTNGJPURFHYEW"));
            //SpiralOrder.spiralOrder(new List<List<int>>() { new List<int>() { 1, 2, 3 }, new List<int>() { 4, 5, 6 }, new List<int>() { 7, 8, 9 } });
            //WaveArray.Arrange(new List<int>() { 1, 2, 3, 4, 5, 6, 7 });
            //PascalTriangle.Print(5);
            //PascalTriangle.KthRow(1);
            //AntiDiagonal.Print(new List<List<int>>() { new List<int>() { 1, 2, 3 }, new List<int>() { 4, 5, 6 }, new List<int>() { 7, 8, 9 } });
            // Console.WriteLine(NobleInteger.Query(new List<int>() { -6, -1, 4 }));
            //Rearrange.Arrange(new List<int>() { 0, 1 });

            //Console.WriteLine(FirstMissingInteger.Find(new List<int>() { 1, 2, 0 }));
            //SetMatrixZeros.Set(new List<List<int>>() { new List<int>() { 1, 2, 3 }, new List<int>() { 4, 0, 6 }, new List<int>() { 7, 8, 9 }, new List<int>() { 10, 11, 12 } });
            //Console.WriteLine(MaxDistance.Distance(new List<int>() { 46158044, 9306314, 51157916, 93803496, 20512678, 55668109, 488932, 24018019, 91386538, 68676911, 92581441, 66802896, 10401330, 57053542, 42836847, 24523157, 50084224, 16223673, 18392448, 61771874, 75040277, 30393366, 1248593, 71015899, 20545868, 75781058, 2819173, 37183571, 94307760, 88949450, 9352766, 26990547, 4035684, 57106547, 62393125, 74101466, 87693129, 84620455, 98589753, 8374427, 59030017, 69501866, 47507712, 84139250, 97401195, 32307123, 41600232, 52669409, 61249959, 88263327, 3194185, 10842291, 37741683, 14638221, 61808847, 86673222, 12380549, 39609235, 98726824, 81436765, 48701855, 42166094, 88595721, 11566537, 63715832, 21604701, 83321269, 34496410, 48653819, 77422556, 51748960, 83040347, 12893783, 57429375, 13500426, 49447417, 50826659, 22709813, 33096541, 55283208, 31924546, 54079534, 38900717, 94495657, 6472104, 47947703, 50659890, 33719501, 57117161, 20478224, 77975153, 52822862, 13155282, 6481416, 67356400, 36491447, 4084060, 5884644, 91621319, 43488994, 71554661, 41611278, 28547265, 26692589, 82826028, 72214268, 98604736, 60193708, 95417547, 73177938, 50713342, 6283439, 79043764, 52027740, 17648022, 33730552, 42851318, 13232185, 95479426, 70580777, 24710823, 48306195, 31248704, 24224431, 99173104, 31216940, 66551773, 94516629, 67345352, 62715266, 8776225, 18603704, 7611906 }));

            //SprialOrder2.SpiralOrder(3);
            //MergeOverlappingIntervals.Overlap(new List<Interval>()
            //{

            //    //[1,3],[2,6],[8,10],[15,18],
            //    new Interval(15,18),
            //    new Interval(2,6),
            //    new Interval(8,10),

            //     new Interval(1,3),

            //});

            //PRETTYPRINT.SpiralOrder(2);
            // Console.WriteLine(-1%20);
            // Console.WriteLine(BinarySearch.Power.CalPower(2, 3, 3));
            //Console.WriteLine(BinarySearch.SortedInsertPosition.Find(new List<int>() { 1, 3, 5, 6 }, 10));
            //SubSet(5);

            // Console.WriteLine(BinarySearch.MatrixSearch.Find(new List<List<int>>() { new List<int>() { 1, 2, 3 }, new List<int>() { 4, 5, 6 }, new List<int>() { 7, 9, 10 }, new List<int>() { 11, 12, 13 } }, 9));
            //Console.WriteLine(BinarySearch.RotatedSortedArraySearch.Find(new List<int>() { 19, 20, 21, 22, 28, 29, 32, 36, 39, 40, 41, 42, 43, 45, 48, 49, 51, 54, 55, 56, 58, 60, 61, 62, 65, 67, 69, 71, 72, 74, 75, 78, 81, 84, 85, 87, 89, 92, 94, 95, 96, 97, 98, 99, 100, 105, 107, 108, 109, 110, 112, 113, 115, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 128, 130, 131, 133, 134, 135, 136, 137, 138, 139, 141, 142, 144, 146, 147, 148, 149, 150, 153, 155, 157, 159, 161, 163, 164, 169, 170, 175, 176, 179, 180, 185, 187, 188, 189, 192, 196, 199, 201, 203, 205, 3, 7, 9, 10, 12, 13, 17 },62));

            //TODO
            //BinarySearch.MedianOfArray.Find(new List<int>() { 1, 4, 5 ,7}, new List<int>() { 2, 3, 6 ,8});

            // BitManipulation.SingleNumber.Find(new List<int>() { 1, 2, 3, 3, 1 });
            //Console.WriteLine(BitManipulation.NumberOf1Bits.Count(uint.MaxValue));
            //Console.WriteLine(uint.MaxValue);
            //Console.WriteLine(BitManipulation.ReverseBits.Reverse(uint.MaxValue));

            //Console.WriteLine(Strings.LengthOfLastWord.CalLength("Hello World "));
            //Console.WriteLine(Strings.ReverseTheString.Reverse("the sky is blue"));

            //TwoPointers.SortByColor.Sort(new List<int>() { 0, 1, 2, 0, 1, 2 });

            //TwoPointers.IntersectionOfSortedArrays.Intersect(new List<int>() { 1, 2, 3, 3, 4, 5, 6 },
            //    new List<int>() { 3, 3, 5 });

            //Console.WriteLine(TwoPointers.Diffk.Find(new List<int>() { 1, 2, 2, 3, 4 }, 0));

            //TwoPointers.RemoveElementFromArray.Remove(new List<int>() { 4, 1, 1, 2, 1, 3 }, 1);

            //Console.WriteLine(Strings.PalindromeString.Check("race a car"));
            //Console.WriteLine(Strings.ZigzagString.Zigzag("PAYPALISHIRING", 4));
            // Console.WriteLine(Strings.ZigzagString.Zigzag("B", 1));

            // Console.WriteLine(Strings.CompareVersionNumbers.Compare("1.0 ", "1"));
            // Console.WriteLine(Strings.StrStr.strStr("bbaabbbbbaabbaabbbbbbabbbabaabbbabbabbbbababbbabbabaaababbbaabaaaba", "babaaa"));
            // Console.WriteLine(Strings.StrStr.strStr("bbbbbbbbab", "baba"));
            //Console.WriteLine(Strings.StrStr.strStr("aaaaaabbaaaaaabaabbbaaababbaabaabbbbbbaabaabbabbabaababbabababbababaabbbabaababb", "babbb"));

            //Console.WriteLine(TwoPointers.ContainerWithMostWater.Find(new List<int>() { 1, 4, 5, 3 }));
            //Console.WriteLine(TwoPointers.MinimizeTheAbsoluteDifference.Diff(new List<int>() { 1, 4, 5, 8, 10 },
            //    new List<int>() { 6, 9, 10 }, new List<int>() { 2, 3, 6, 10 }));

            // Console.WriteLine(Strings.MinimumCharactersPalidromeString.Cal("ABC"));

            //Console.WriteLine(Mathh.NumbersOfLengthNAndValueLessThanK.Find(new List<int>() { 0, 1, 2, 5 }, 2, 40));
            // Console.WriteLine(Mathh.NumbersOfLengthNAndValueLessThanK.Find(new List<int>() { 0, 1, 5 }, 1, 2)); 

            // Console.WriteLine(Level3.Kthsmallest.Find(new List<int>() { 2, 1, 4, 3, 2 }, 3));

            // LinkedLists.SwapListNodesInPairs.Swap(null);

            //ListNodeInvoker.Invoke();

            //StackInvoker.Invoke();

            // HashingInvoker.Invoke();
            //Backtracking.BacktrackingInvoker.Invoke();

            
            //DPInvoker.Invoke();

            // Level3.QuickSort.Sort(new List<int>() { 2, 1, 4, 3, 2 });

            //Console.WriteLine(GridUn iquePaths(1000, 3000));
            // Console.WriteLine(PairwiseHammingDistance.Distance(new List<int>() { 96, 96, 7, 81, 2, 13 }));

            //FizzBuzz(20);
            // Console.WriteLine(CoPrime(30, 12));

            //DateTime baseDate = DateTime.Now.AddDays(4);
            //int businessDays = 9;

            //int reminder = businessDays % 5;
            //int factor = businessDays / 5;

            //int actualDays = factor * 7 + reminder;

            //if (baseDate.DayOfWeek == DayOfWeek.Saturday)
            //{
            //    actualDays += 1;
            //}
            //if (baseDate.DayOfWeek == DayOfWeek.Friday)
            //{
            //    actualDays += 2;
            //}

            //DateTime calDate = baseDate.AddDays(actualDays);
            //if (calDate.DayOfWeek == DayOfWeek.Saturday)
            //{
            //    calDate = calDate.AddDays(2);
            //}
            //if (calDate.DayOfWeek == DayOfWeek.Sunday)
            //{
            //    calDate = calDate.AddDays(1);
            //}
            //Console.WriteLine("baseDate: " + baseDate);
            //Console.WriteLine("businessDays: " + businessDays);
            //Console.WriteLine("calDate: " + calDate);
        }



        static string reverseParentheses(string s)
        {
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == ')')
                {
                    s = s.Substring(0, i) + s.Substring(i + 1);
                    i--;
                    var reversed = "";
                    while (s[i] != '(')
                    {
                        reversed += s[i];
                        s = s.Substring(0, i) + s.Substring(i + 1);
                        i--;
                    }
                    s = s.Substring(0, i) + reversed + s.Substring(i + 1);
                    i += reversed.Length - 1;
                }
            }
            return s;
        }

        //static string reverseParentheses(string s)
        //{
        //    bool end = true;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (s[i] == '(' || s[i] == ')')
        //        {
        //            end = false;
        //            break;
        //        }
        //    }
        //    if (end)
        //    {
        //        return s;
        //    }

        //    string result = string.Empty;
        //    int temp = 0, vt1 = -1, vt2 = -1;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (s[i] == '(')
        //        {
        //            if (temp == 0)
        //            {
        //                vt1 = i + 1;
        //            }

        //            temp++;
        //        }
        //        else if (s[i] == ')')
        //        {
        //            temp--;
        //            if (temp == 0)
        //            {
        //                vt2 = i - 1;
        //            }

        //            if (temp == 0)
        //            {
        //                for (int j = vt2; j >= vt1; j--)
        //                {
        //                    if (s[j] == ')')
        //                    {
        //                        result += '(';
        //                    }
        //                    else if (s[j] == '(')
        //                    {
        //                        result += ')';
        //                    }
        //                    else
        //                    {
        //                        result += s[j];
        //                    }
        //                }
        //            }
        //        }
        //        else if (temp == 0)
        //        {
        //            result += s[i];
        //        }
        //    }
        //    return reverseParentheses(result);
        //}

        static int[] changeRoot(int[] a, int nR)
        {
            int idx = nR;

            int newVal = nR;

            while (true)
            {
                int old = a[idx];
                a[idx] = newVal;

                newVal = idx;
                idx = old;
                if (newVal == idx)
                {
                    break;
                }

            }
            return a;
        }
        //int sumInRange(int[] nums, int[][] queries)
        //{
        //    /*long sum = 0;
        //    for(var i=0;i<queries.Length;i++){
        //        for(var j=queries[i][0];j<=queries[i][1];j++){
        //            sum =  (sum+ (long) nums[j]);
        //            Console.WriteLine(sum);
        //            if(sum > 1000000007){
        //                sum = sum % 1000000007;
        //            }
        //        }
        //    }
        //    if(sum > 1000000007){
        //        sum = sum % 1000000007;
        //    }
        //    return (int)sum;*/
        //    int sum = 0;
        //    for (var j = 0; j < queries.Length; j++)
        //    {
        //        sum = nums.Take(queries[j][0]).Sum(x => x % 1000000007);
        //    }
        //    return sum % 1000000007;
        //}

        //int[] traverseTree(Tree<int> t)
        //{
        //    List<int> a = new List<int>();
        //    if (null != t)
        //    {
        //        Queue<ConsoleApplication4.Tree> q = new Queue<ConsoleApplication4.Tree>();
        //        q.Enqueue(t);
        //        while (q.Count > 0)
        //        {
        //            Tree temp = q.Dequeue();
        //            a.Add(temp.value);
        //            if (temp.left != null)
        //            {
        //                q.Push(t.left);
        //            }
        //            if (temp.right != null)
        //            {
        //                q.Push(t.right);
        //            }
        //        }

        //    }
        //    return a.ToArray();
        //}

        string[][][] proCategorization(string[] pros, string[][] preferences)
        {
            SortedDictionary<string, List<string>> d = new SortedDictionary<string, List<string>>();
            for (var i = 0; i < preferences.Length; i++)
            {
                for (var j = 0; j < preferences[i].Length; j++)
                {
                    if (!d.ContainsKey(preferences[i][j]))
                    {
                        d.Add(preferences[i][j], new List<string>() { pros[i] });
                    }
                    else
                    {
                        d[preferences[i][j]].Add(pros[i]);
                    }
                }
            }
            List<string[][]> cat = new List<string[][]>();
            foreach (var de in d)
            {
                string[][] t = new string[2][];

                t[0] = new string[] { de.Key };
                var temp = de.Value.ToList();
                temp.Sort();

                t[1] = temp.ToArray();
                cat.Add(t);
            }
            return cat.ToArray();
        }

        static int[] constructArray(int s)
        {
            List<int> res = new List<int>();
            int mid = s % 2 == 0 ? s / 2 : (s / 2) + 1;
            int lastNum = 0;
            for (int i = 0; i < mid; i++)
            {
                res.Add(i + 1);
                lastNum = i + 1;
                if (i != (s - i) && (s - i) != lastNum)
                {
                    res.Add(s - i);

                }
                else
                {
                    break;
                }

            }
            return res.ToArray();
        }

        static string decodeString(string a)
        {
            Stack<string> s = new Stack<string>();
            StringBuilder sb = new StringBuilder();

            for (var i = 0; i < a.Length; i++)
            {
                if (a[i] == ']')
                {
                    StringBuilder sb2 = new StringBuilder();
                    while (s.Count > 0 && s.Peek() != "[")
                    {
                        sb2.Insert(0, s.Pop());
                    }

                    if (s.Count > 0)
                    {
                        if (s.Peek() == "[")
                        {
                            s.Pop();
                        }
                        if (s.Count > 0)
                        {
                            string num = s.Peek();
                            int res = 0;
                            if (Int32.TryParse(num, out res))
                            {
                                int count = 0;
                                StringBuilder b3 = new StringBuilder();
                                while (count < res)
                                {
                                    b3.Append(sb2);
                                    count++;
                                }
                                //sb.Insert(0, b3.ToString());
                                s.Pop();
                                s.Push(b3.ToString());
                            }
                            else
                            {
                                s.Push(sb2.ToString());
                            }
                        }
                        else
                        {
                            s.Push(sb2.ToString());
                        }
                    }
                    else
                    {
                        sb.Insert(0, sb2.ToString());
                    }
                }
                else
                {
                    s.Push(a[i].ToString());
                }
            }
            while (s.Count > 0)
            {
                sb.Insert(0, s.Pop());
            }
            return sb.ToString();
        }



        static bool isLucky(int n)
        {
            int a = n;
            int b = n;
            int sum1 = 0;
            int sum2 = 0;
            int count = 0;
            while (a > 0)
            {
                a = a / 10;
                count++;
            }
            int c2 = 0;
            while (b > 0)
            {
                int rem = b % 10;
                b = b / 10;
                if (c2 < count / 2)
                {
                    sum1 += rem;
                }
                else
                {
                    sum2 += rem;
                }
                c2++;
            }
            return sum1 == sum2;
        }
        static int[] findDeepest(string s)
        {
            SortedDictionary<int, List<int>> d = new SortedDictionary<int, List<int>>();
            int count = 0;
            int maxSofar = 0;
            bool isOpen = false;
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':
                        count++;
                        isOpen = true;
                        maxSofar = Math.Max(maxSofar, count);

                        break;
                    case ')':
                        isOpen = false;
                        count--;
                        break;
                    case ' ':
                        break;
                    default:
                        StringBuilder sb = new StringBuilder();
                        while (i < s.Length && s[i] != ')' && s[i] != '(' && s[i] != ' ')
                        {
                            sb.Append(s[i]);
                            i++;
                        }
                        int val = Convert.ToInt32(sb.ToString());
                        if (!d.ContainsKey(count))
                        {
                            d.Add(count, new List<int>() { val });
                        }
                        else
                        {
                            d[count].Add(val);
                        }
                        break;
                }
            }
            return d[d.Count].ToArray();
        }
        public static int isPower(int A)
        {
            if (A == 1 || A == 0)
            {
                return 1;
            }
            if (A > 0)
            {
                double root = Math.Sqrt(A);

                for (int i = 2; i <= root; i++)
                {
                    int prd = i;
                    while (prd <= A && prd > 0)
                    {
                        prd *= i;
                        if (prd == A)
                        {

                            return 1;
                        }
                    }
                }
            }
            return 0;
        }

        //vector<int> Solution::rotateArray(vector<int> &A, int B)
        //{
        //    vector<int> ret;

        //    for (int i = 0; i < A.size(); i++)
        //    {
        //        int index = i + B;
        //        if (index >= A.size())
        //        {
        //            index = index % A.size();
        //        }
        //        ret.push_back(A[index]);
        //    }
        //    return ret;
        //}


        /*
         Given an even number ( greater than 2 ), return two prime numbers whose sum will be equal to given number.

NOTE A solution will always exist. read Goldbach’s conjecture

Example:


Input : 4
Output: 2 + 2 = 4

If there are more than one solutions possible, return the lexicographically smaller solution.

If [a, b] is one solution with a <= b,
and [c,d] is another solution with c <= d, then

[a, b] < [c, d] 

If a < c OR a==c AND b < d. 
         */
        public static List<int> primesum(int A)
        {
            bool[] isPrime = AllPrimes(A);

            for (int i = 0; i < A; i++)
            {
                if (isPrime[i] && isPrime[A - i])
                {
                    return new List<int>()
                    {
                        i, A-i
                    };
                }
            }
            return new List<int>();

        }
        public static bool[] AllPrimes(int A)
        {
            bool[] isPrime = new bool[A + 1];

            isPrime[0] = isPrime[1] = false;

            for (int i = 2; i <= A; i++)
            {
                isPrime[i] = true;
            }

            for (int p = 2; p * p <= A; p++)
            {
                if (isPrime[p] == true)
                {
                    for (int j = p * 2; j <= A; j = j + p)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            return isPrime;

        }

        public List<int> allFactors(int A)
        {

            List<int> allFactors = new List<int>();
            for (int i = 1; i <= A / 2; i++)
            {
                if (A % i == 0)
                {
                    allFactors.Add(i);
                }
            }
            allFactors.Sort();
            //allFactors.Add(A);
            return allFactors;
        }

        public string findDigitsInBinary(int A)
        {
            if (A < 0)
            {
                return string.Empty;
            }
            if (A == 0)
            {
                return "0";
            }
            StringBuilder sb = new StringBuilder();
            int original = A;
            while (original > 0)
            {
                int reminder = original % 2;
                sb.Insert(0, reminder);
                original = original / 2;
            }
            return sb.ToString();
        }

        //Given a number N, find all prime numbers upto N(N included).
        public List<int> sieve(int A)
        {

            if (A <= 0)
            {
                return new List<int>();
            }

            List<int> allPrimes = new List<int>();
            bool[] isPrime = new bool[A + 1];

            isPrime[0] = isPrime[1] = false;

            for (int i = 2; i <= A; i++)
            {
                isPrime[i] = true;
            }

            for (int p = 2; p * p <= A; p++)
            {
                if (isPrime[p] == true)
                {
                    for (int j = p * 2; j <= A; j = j + p)
                    {
                        isPrime[j] = false;
                    }
                }
            }
            for (int i = 0; i < isPrime.Length; i++)
            {
                if (isPrime[i])
                {
                    allPrimes.Add(i);

                }
            }


            return allPrimes;
        }

        //Given a number N, verify if N is prime or not.


        public int isPrime(int A)
        {
            if (A <= 1)
            {
                return 0;
            }
            if (A <= 3)
            {
                return 1;
            }
            if (A % 2 == 0 || A % 3 == 0)
            {
                return 0;
            }

            for (int i = 5; i * i <= A; i = i + 6)
            {

                if (A % i == 0 || A % (i + 2) == 0)
                {
                    return 0;
                }
            }
            return 1;
        }


        public static int solve(List<int> A, int B, int C)
        {
            if (B < 1 || B > 9)
            {
                return 0;
            }
            List<int> random = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                //for (int j = 0; j < A.Count; j++)
                //{
                int temp = 0;
                int temp2 = 0;
                for (int k = 0; k < B; k++)
                {
                    temp = temp * 10 + A[(i + k) % A.Count];

                }
                random.Add(temp);

                int reminder = 0, temp3 = temp, rev = 0;
                while (temp3 > 0)
                {
                    reminder = temp3 % 10;
                    rev = rev * 10 + reminder;
                    temp3 = temp3 / 10;
                }


                random.Add(rev);
                //  }
            }

            for (int i = 0; i < A.Count; i++)
            {
                int temp = 0;
                for (int j = 0; j < B; j++)
                {
                    temp = temp * 10 + A[i];
                }
                random.Add(temp);
            }

            foreach (var item in random)
            {
                Console.WriteLine(item);
            }

            return 0;
        }
        //Min Steps in Infinite Grid

        public int coverPoints(List<int> A, List<int> B)
        {
            if (A.Count != B.Count)
            {
                return 0;
            }
            int total = 0;
            for (int i = 0; i < A.Count - 1; i++)
            {
                int left = A[i + 1] - A[i];
                if (left < 0)
                {
                    left = -left;
                }
                int right = B[i + 1] - B[i];
                if (right < 0)
                {
                    right = -right;
                }
                if (left <= right)
                {
                    total += right;
                }
                else
                {
                    total += left;
                }
            }
            return total;
        }

        public int AddOne(int A)
        {
            int offset = 1;

            while ((A & offset) > 0)
            {
                A = A ^ offset;
                offset <<= 1;
            }

            A = A ^ offset;

            return A;
        }

        //public static List<int> plusOne(List<int> A)
        //{
        //    if (null == A || A.Count == 0)
        //    {
        //        return A;
        //    }

        //    List<string> AStr = new List<string>();

        //    foreach (var item in A)
        //    {
        //        AStr.Add(item.ToString());
        //    }

        //    string numText = string.Join("", AStr.ToArray());
        //    Console.WriteLine(numText);
        //    if (Convert.ToInt64(numText) < 0)
        //    {
        //        return new List<int>();
        //    }
        //    Int64 num = Convert.ToInt64(numText) + 1;

        //    List<int> finalNum = new List<int>();
        //    long reminder = 0;
        //    while (num > 0)
        //    {
        //        reminder = num % 10;
        //        finalNum.Add((int)reminder);
        //        num = num / 10;
        //    }

        //    finalNum.Reverse();

        //    foreach (var item in finalNum)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    return finalNum;
        //}

        //add one to an int array
        public static List<int> plusOne(List<int> A)
        {
            if (null == A || A.Count == 0)
            {
                return A;
            }
            bool carry = false;
            List<int> final = new List<int>();
            int first = A[A.Count - 1];
            first++;
            final.Add(first % 10);
            if (first == 10)
            {
                carry = true;
            }
            for (int i = A.Count - 2; i >= 0; i--)
            {
                int sum = A[i];
                if (carry)
                {
                    sum++;
                    carry = false;
                }


                final.Add(sum % 10);
                if (sum == 10)
                {
                    carry = true;
                }
            }

            if (carry)
            {
                final.Add(1);
            }

            bool isZero = true;
            for (int i = final.Count - 1; i >= 0; i--)
            {
                if (final[i] == 0 && isZero)
                {
                    final.RemoveAt(i);
                    isZero = true;
                }
                else
                {
                    isZero = false;
                    break;
                }
            }


            final.Reverse();


            foreach (var item in final)
            {
                Console.WriteLine(item);
            }
            return final;
        }

        public static List<int> MaxSubArray(List<int> input)
        {
            int maxCurrent = 0, maxSoFar = Int32.MinValue, startIdx = 0, endIdx = 0, temp = 0;

            for (int i = 0; i < input.Count; i++)
            {

                maxCurrent = maxCurrent + input[i];


                if (maxSoFar < maxCurrent)
                {
                    maxSoFar = maxCurrent;
                    startIdx = temp;
                    endIdx = i;
                }
                if (maxCurrent < 0)
                {
                    maxCurrent = 0;
                    temp = i + 1;
                }
            }

            Console.WriteLine(maxSoFar);
            Console.WriteLine("startIdx:" + startIdx + " endIdx:" + endIdx);
            return input;

        }

        public static string LargestNum(List<int> input)
        {
            List<string> strInput = new List<string>();

            foreach (var item in input)
            {
                strInput.Add(item.ToString());
            }
            CustomComparer comparer = new CustomComparer();
            strInput.Sort(comparer);
            Console.WriteLine(String.Join("", strInput.ToArray()));
            strInput.Reverse();

            Console.WriteLine(String.Join("", strInput.ToArray()));
            return String.Join("", strInput.ToArray());
        }
        public class CustomComparer : IComparer<string>
        {
            public int Compare(string left, string right)
            {
                string leftright = left + right;
                string rightleft = right + left;

                return rightleft.CompareTo(leftright);
            }

        }



        public int RepeatedNumber(List<int> A)
        {
            if (null == A || A.Count == 0)
            {
                return -1;
            }
            Dictionary<int, int> dicA = new Dictionary<int, int>();
            foreach (var item in A)
            {
                if (dicA.ContainsKey(item))
                {
                    return item;
                }
                dicA.Add(item, item);
            }
            return -1;
        }

        public static int RepeatedNumberNBy3(List<int> A)
        {
            if (null == A || A.Count == 0)
            {
                return -1;
            }
            int itemLimit = A.Count / 3;

            Dictionary<int, int> dicA = new Dictionary<int, int>();
            foreach (var item in A)
            {
                int count = 1;
                if (!dicA.ContainsKey(item))
                {
                    dicA.Add(item, count);

                }
                else
                {
                    count = dicA[item];
                    count++;
                    dicA[item] = count;

                }
                if (count > itemLimit)
                {
                    return item;
                }
            }
            return -1;
        }

        public static int ExcelColumn(string col)
        {
            if (string.IsNullOrEmpty(col))
            {
                return 0;
            }
            int num = 0;
            for (int i = col.Length - 1; i >= 0; i--)
            {

                int offset = 0;
                offset = col[i] - 'A' + 1;
                if (offset < 0 || offset > 26)
                {
                    return 0;
                }
                num = num + offset * (int)Math.Pow(26, col.Length - i - 1);
            }
            return num;
        }

        public static string ExcelColumnTitle(int A)
        {
            if (A <= 0)
            {
                return string.Empty;
            }

            int div = A;
            int offset = (int)'A';
            Console.WriteLine(offset);
            StringBuilder title = new StringBuilder();
            while (A > 0)
            {
                A--;
                div = A % 26;
                Console.WriteLine("div: " + div);
                A = A / 26;

                title.Insert(0, ((char)(div + offset)));
                Console.WriteLine(title);
            }


            return title.ToString();
        }

        public static void ReArrange(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (i < 0 || i > A.Length - 1)
                {
                    return;
                }
                if (A[i] == i)
                {
                    continue;
                }
                int temp = A[i];
                A[i] = i;

                while (A[temp] != temp)
                {
                    int temp2 = A[temp];
                    A[temp] = temp;
                    temp = A[temp2];
                    A[temp2] = temp2;
                }

            }
            foreach (var item in A)
            {
                Console.WriteLine(item);
            }
        }

        public static int GCD(int A, int B)
        {
            if (B == 0)
            {
                return A;

            }

            return GCD(B, A % B);
        }
        public static int TrialingZeros(int A)
        {
            if (A <= 0)
            {
                return 0;
            }
            int count = 0;
            //for (int i = 5; i <= A; i = i + 5)
            //{
            //    int j = i;
            //    //count++;
            //    while (j / 5 > 0)
            //    {
            //        count++;
            //        j = j / 5;
            //    }
            //}
            for (int i = 5; A / i >= 1; i = i * 5)
            {
                count += A / i;
            }
            return count;
        }

        public static int Permutations(string A)
        {
            if (null == A || A.Length == 0)
            {
                return 0;
            }
            char[] c = A.ToArray();
            Array.Sort(c);

            foreach (var item in c)
            {
                Console.WriteLine(item);
            }

            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < c.Length; i++)
            {
                dic.Add(c[i], i);
            }
            int rank = 1;
            List<int> visitedIndexes = new List<int>();
            for (int i = 0; i < A.Length - 1; i++)
            {
                int index = dic[A[i]];
                foreach (var item in visitedIndexes)
                {
                    if (index > item)
                    {
                        index--;
                    }
                }

                visitedIndexes.Add(index);

                // index = index - i;
                if (index < 0)
                {
                    continue;
                }
                Console.WriteLine(index);
                int offset = A.Length - i - 1;
                Console.WriteLine(offset);
                int prod = index * Factorial(offset);
                Console.WriteLine(prod);
                rank += prod;

            }
            return rank;
        }
        public static int Factorial(int n)
        {
            int prod = 1;
            for (int i = 1; i <= n; i++)
            {
                prod *= i;
            }
            return prod;
        }

        public static List<string> FizzBuzz(int A)
        {
            List<string> fizzBuzz = new List<string>();
            if (A <= 0)
            {
                return fizzBuzz;
            }
            const string ByThreeStr = "Fizz";
            const string ByFiveStr = "Buzz";
            const string ByThreeFiveStr = "FizzBuzz";
            for (int i = 1; i <= A; i++)
            {
                bool isByThree = (i % 3 == 0);
                bool isByFive = (i % 5 == 0);
                string buzzStr = i.ToString();
                if (isByThree)
                {
                    buzzStr = ByThreeStr;
                    if (isByFive)
                    {
                        buzzStr = ByThreeFiveStr;
                    }
                }
                else if (isByFive)
                {
                    buzzStr = ByFiveStr;
                }
                fizzBuzz.Add(buzzStr);
            }

            foreach (var item in fizzBuzz)
            {
                Console.WriteLine(item);
            }
            return fizzBuzz;
        }

        public static int CoPrime(int A, int B)
        {
            if (A <= 0 || B <= 0)
            {
                return 0;
            }
            if (B == 1)
            {
                return 1;
            }
            List<int> factorsOfA = new List<int>();

            for (int i = 2; i * i <= A; i++)
            {
                if (A % i == 0)
                {
                    factorsOfA.Add(i);
                }
            }

            foreach (var item in factorsOfA)
            {
                if (B % item != 0)
                {
                    return item;
                }
            }
            return 1;
        }

        public static void SubSet(int n)
        {
            for (int i = 0; i < 1 << n; i++)
            {
                // Console.WriteLine(i);

                List<int> subSet = new List<int>();
                for (int b = 0; b < n; b++)
                {

                    if ((b & (1 << i)) > 0)
                    {
                        subSet.Add(b);
                    }
                }
                foreach (var item in subSet)
                {
                    Console.WriteLine(item);
                }
            }
        }


        public static int GridUniquePaths(int A, int B)
        {
            Int64 paths = 1;

            for (int i = B; i < A + B - 1; i++)
            {
                paths *= i;
                paths /= (i - B + 1);
                Console.WriteLine(paths);
            }

            Console.WriteLine(paths);
            return (int)paths;
        }
    }
}
