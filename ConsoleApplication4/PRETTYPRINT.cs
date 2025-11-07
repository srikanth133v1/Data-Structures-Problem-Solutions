using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class PRETTYPRINT
    {
        public static List<List<int>> SpiralOrder(int n)
        {
            if (n < 0)
            {
                return new List<List<int>>();
            }
            
            int num = n + 1;
            n = n * 2 - 1;
            int[,] A = new int[n, n];

            int t = 0, b = n - 1, l = 0, r = n - 1;
            int dir = 0;

            List<int> elements = new List<int>();
            int count = 0;
            while (t <= b && l <= r)
            {

                if (dir == 0)
                {
                    num = num - 1;
                    for (int i = l; i <= r; i++)
                    {
                        A[t, i] = num;
                    }
                    t++;
                    dir = 1;

                    count++;
                }
                else if (dir == 1)
                {
                    for (int i = t; i <= b; i++)
                    {
                        A[i, r] = num;
                    }
                    r--;
                    dir = 2;
                    count++;
                }
                else if (dir == 2)
                {
                    for (int i = r; i >= l; i--)
                    {
                        A[b, i] = num;
                    }
                    b--;
                    dir = 3;
                    count++;
                }
                else if (dir == 3)
                {
                    for (int i = b; i >= t; i--)
                    {
                        A[i, l] = num;
                    }
                    l++;
                    dir = 0;
                    count++;
                }
            }
            List<List<int>> matrix = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine(A[i, j]);
                    row.Add(A[i, j]);
                }
                matrix.Add(row);
            }


            return matrix;
        }
    }
}
