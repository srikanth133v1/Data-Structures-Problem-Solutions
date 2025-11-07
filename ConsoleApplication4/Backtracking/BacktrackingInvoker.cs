using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Backtracking
{
    public class BacktrackingInvoker
    {
        public static void Invoke()
        {
            //List<List<int>> comb = new List<List<int>>();
            //int[] data = new int[3];
            //Combinations.Generate(new List<int>() { 1, 2, 3, 4, 5 }, data, 0, 4, 0, 3, comb);

            //foreach (var item in comb)
            //{
            //    foreach (var i in item)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    Console.WriteLine();
            //}

            //GenerateParanthesis.Generate(3);

            //  Console.WriteLine(1<<3);

            // GrayCodes.Generate(10);
            //SudoKuInvoker();
            //Console.WriteLine(""+ Convert.ToChar('0'+1));
            //SudoKuInvokerChsr();

            var t = new List<int>() {1,2,3 };
            PermutationsII.ListAll(t);
            var r = PermutationsII.Result;
            foreach (var item in r)
            {
                Console.WriteLine(string.Join(", ", item));
            }
        }

        public static void SudoKuInvoker()
        {
            List<List<int>> num = new List<List<int>>()
            {   new List<int>(){3, 0, 6, 5, 0, 8, 4, 0, 0},
                new List<int>(){5, 2, 0, 0, 0, 0, 0, 0, 0},
                new List<int>(){0, 8, 7, 0, 0, 0, 0, 3, 1},
                new List<int>(){0, 0, 3, 0, 1, 0, 0, 8, 0},
                new List<int>(){9, 0, 0, 8, 6, 3, 0, 0, 5},
                new List<int>(){0, 5, 0, 0, 9, 0, 6, 0, 0},
                new List<int>(){1, 3, 0, 0, 0, 0, 2, 5, 0},
                new List<int>(){0, 0, 0, 0, 0, 0, 0, 7, 4},
                new List<int>(){0, 0, 5, 2, 0, 6, 3, 0, 0}
            };
            if (Sudoku.Solve(num))
            {
                foreach (var item in num)
                {
                    for (int i = 0; i < item.Count; i++)
                    {
                        Console.Write(item[i] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Cannot be solved");
            }
        }

        public static void SudoKuInvokerChsr()
        {
            List<List<char>> num = new List<List<char>>()
            {   new List<char>() {'3', '.', '6', '5', '.', '8', '4', '.', '.'},
                new List<char>() {'5', '2', '.', '.', '.', '.', '.', '.', '.'},
                new List<char>() {'.', '8', '7', '.', '.', '.', '.', '3', '1'},
                new List<char>() {'.', '.', '3', '.', '1', '.', '.', '8', '.'},
                new List<char>() {'9', '.', '.', '8', '6', '3', '.', '.', '5'},
                new List<char>() {'.', '5', '.', '.', '9', '.', '6', '.', '.'},
                new List<char>() {'1', '3', '.', '.', '.', '.', '2', '5', '.'},
                new List<char>() {'.', '.', '.', '.', '.', '.', '.', '7', '4'},
                new List<char>() {'.', '.', '5', '2', '.', '6', '3', '.', '.'}
            };
            //if (SudokuChar.Solve(num))
            //{
            //    foreach (var item in num)
            //    {
            //        for (int i = 0; i < item.Count; i++)
            //        {
            //            Console.Write(item[i] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Cannot be solved");
            //}
        }

        public static void Invoke_Old()
        {
            // Permutations.Generate(new List<int>() { 1, 2, 3 }, 3, 3);

            List<List<int>> subsets = new List<List<int>>();
            ///Subset_Old.Generate(new List<int>() { 1, 2, 2 }, null, 0, 3, subsets);
            SubsetII.Generate(new List<int>() { 1, 2, 2 }, null, 0, 3, subsets);
            subsets.Sort(new ListComparer());
            subsets = subsets.Distinct(new ListEqualityComparer()).ToList();
            foreach (var item in subsets)
            {
                foreach (var i in item)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
    public class ListComparer : IComparer<List<int>>
    {
        public int Compare(List<int> a, List<int> b)
        {
            int an = a.Count;

            int bn = b.Count;

            for (int i = 0; i < Math.Min(an, bn); i++)
            {

                int cmp = a[i].CompareTo(b[i]);

                if (cmp != 0)

                    return cmp;

            }

            return a.Count.CompareTo(b.Count);

        }
        public int GetHashCode(List<int> x) { return x.Count; }
    }

    public class ListEqualityComparer : IEqualityComparer<List<int>>
    {
        public bool Equals(List<int> a, List<int> b)
        {
            int an = a.Count;

            int bn = b.Count;

            for (int i = 0; i < Math.Min(an, bn); i++)
            {

                bool cmp = a[i].Equals(b[i]);

                if (!cmp)

                    return cmp;

            }

            return a.Count.Equals(b.Count);

        }
        // public int GetHashCode(List<int> x) => x.Count;
        public int GetHashCode(List<int> x) { return x.Count; }
    }
}
