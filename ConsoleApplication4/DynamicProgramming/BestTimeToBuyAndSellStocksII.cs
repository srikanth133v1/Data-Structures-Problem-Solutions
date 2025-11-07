using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.DynamicProgramming
{
    public class BestTimeToBuyAndSellStocksII
    {
        public static int CalProfit(List<int> A)
        {
            if (null == A || A.Count <= 1)
            {
                return 0;
            }
            int maxProfit = 0;
            int i = 0;

            while (i < A.Count - 1)
            {
                while (i < A.Count - 1 && A[i + 1] <= A[i])
                {
                    i++;
                }

                if (i == A.Count - 1)
                {
                    break;
                }

                int buy = A[i++];

                while (i < A.Count && A[i] >= A[i - 1])
                {
                    i++;
                }
                int sell = A[i - 1];

                maxProfit += (sell - buy);
            }

            return maxProfit;
        }

    }
}

