using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Backtracking
{
    public class Combinations
    {
        public static void Collect(int[] data, List<List<int>> comb)
        {
            List<int> c = new List<int>(data);
            comb.Add(c);
        }

        public static void Generate(List<int> A, int[] data, int start, int end, int index, int size, List<List<int>> comb)
        {
            if (index == size)
            {
                Collect(data, comb);
                return;

            }

            for (int i = start; i <= end && (end - i + 1) >= (size - index); i++)
            {
                data[index] = A[i];
                Generate(A, data, i + 1, end, index + 1, size, comb);
            }
        }
    }
}
