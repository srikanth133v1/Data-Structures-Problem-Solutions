using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.CodeFights
{
    public class CodeFightsInvoker
    {
        public static void Invoke()
        {
            Console.WriteLine(ReverseInParanthesis.Invoke("foo(bar(baz))blim"));

            //var t = new int[,] { { 2, 5 }, { 5, 7 }, { 5, 1 }, { 1, 9 }, { 1, 0 }, { 7, 6 }, { 6, 3 }, { 3, 8 }, { 8, 4 } };
            //Console.WriteLine(TreeDiameter.Invoke(10, t));
            return;
            //int[][] res = CodeFights.ClimbingStaircase.climbingStaircase(4, 2);

            //foreach (var i in res)
            //{
            //    Console.WriteLine(string.Join(" ,", i));
            //}
            //var s = TextJustification.textJustification(
            //    new string[] { "This", "is", "an", "example", "of", "text", "justification." }, 16);



            //Console.WriteLine(LongestIncreasingSubsequenceEO.Cal(new List<int>() { 3, 2, 8, 1, 4, 3 }));
            //var res = NewNumeralSystem.Find('E');

            //foreach (var iRe in res)
            //{
            //    Console.WriteLine(iRe);
            //}
            //var a = DigitRootSort.digitRootSort(new int[] { 13, 20, 7, 4 });
            //Console.WriteLine(string.Join(", ", a));

            // Console.WriteLine(PeriodicSequence.periodicSequence(1, 2, 3, 5));

            //Console.WriteLine(Kbonacci.kbonacci(100000, 16));

            //Console.WriteLine(Kbonacci.kbonacci(8, 2));

            //var r = Dashes.dashes(4);
            //foreach (var item in r)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(SortByString.sortByString("weather", "therapyw"));
            //Console.WriteLine(string.Join(", ", sortedSquaredArray.sortedSquaredArray1(new int[] { 1, 4, 6, 6, 11, 12, 19, 24, 49, 50 })));
            //Console.WriteLine(SumUpNumbers.sumUpNumbers("2 apples, 12 oranges"));
            //           Console.WriteLine(string.Join(",", LeastAppearance.leastAppearance(
            //               new int[][]{new int[]{4,8},
            //new int[]{92,92},
            //new int[]{9,53},
            //new int[]{44,48},
            //new int[]{2,67},
            //new int[]{3,3},
            //new int[]{60,93},
            //new int[]{18,37},
            //new int[]{7,15},
            //new int[]{2,4}})));

            //Console.WriteLine(string.Join(", ", MinimumOnStack.minimumOnStack(new string[] { "push 10", "min", "push 5", "min", "push 8", "min", "pop", "min", "pop", "min" })));
        }
    }
}
