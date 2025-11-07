using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.BinarySearch
{
    public class MatrixSearch
    {
        public static int Find(List<List<int>> A, int x)
        {
            int rowCount = A.Count;
            int colCount = A[0].Count;
            int low = 0, high = (rowCount * colCount) - 1;
            int rowHigh = rowCount - 1;
            int colHigh = colCount - 1;
            while (low <= rowHigh)
            {
                int mid = (low + rowHigh) / 2;

                if (A[mid][0] == x)
                {
                    return 1;
                }

                if (x < A[mid][0])
                {
                    rowHigh = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }


            }
            int colLow = 0;
            if (low != 0)
            {
                low = low - 1;
            }
            
            while (colLow <= colHigh)
            {
                int mid = (colLow + colHigh) / 2;

                if (A[low][mid] == x)
                {
                    return 1;
                }

                if (x < A[low][mid])
                {
                    colHigh = mid - 1;
                }
                else
                {
                    colLow = mid + 1;
                }
            }

            return 0;
        }
    }
}
