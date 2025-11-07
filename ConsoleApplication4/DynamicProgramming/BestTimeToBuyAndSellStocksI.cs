using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.DynamicProgramming
{
    public class BestTimeToBuyAndSellStocksI
    {
        public static int CalProfit(List<int> A)
        {
            int maxProfit = int.MinValue;
            for (int i = 0; i < A.Count - 1; i++)
            {
                for (int j = i + 1; j < A.Count; j++)
                {

                    int diff = A[j] - A[i];
                    maxProfit = Math.Max(diff, maxProfit);

                }
            }
            return maxProfit;
        }
        public static int CalProfit1(List<int> A)
        {
            int maxDiff = A[1] - A[0];
            int minSoFar = A[0];
            for (int i = 1; i < A.Count; i++)
            {
                if (A[i] - minSoFar > maxDiff)
                {
                    maxDiff = A[i] - minSoFar;

                }
                if (A[i] < minSoFar)
                {
                    minSoFar = A[i];
                }
            }
            return maxDiff;
        }
    }
}

