using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class SprialOrder2
    {
        public static List<List<int>> SpiralOrder(int n)
        {
            //List<List<int>> A = new List<List<int>>();
            int[,] A = new int[n, n];

            int t = 0, b = n - 1, l = 0, r = n - 1;
            int dir = 0;
            int num = 1;
            List<int> elements = new List<int>();
            while (t <= b && l <= r)
            {
                if (dir == 0)
                {
                    for (int i = l; i <= r; i++)
                    {
                        // elements.Add(A[t][i]);
                        A[t, i] = num;
                        num++;
                        //Console.WriteLine(A[t][i]);
                    }
                    t++;
                    dir = 1;
                }
                else if (dir == 1)
                {
                    for (int i = t; i <= b; i++)
                    {
                        // elements.Add(A[i][r]);
                        A[i, r] = num;
                        num++;
                    }
                    r--;
                    dir = 2;
                }
                else if (dir == 2)
                {
                    for (int i = r; i >= l; i--)
                    {
                        //elements.Add(A[b][i]);
                        A[b, i] = num;
                        num++;
                    }
                    b--;
                    dir = 3;
                }
                else if (dir == 3)
                {
                    for (int i = b; i >= t; i--)
                    {
                        //elements.Add(A[i][l]);
                        A[i, l] = num;
                        num++;
                    }
                    l++;
                    dir = 0;
                }
            }
            List<List<int>> matrix = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < n; j++)
                {
                   // Console.WriteLine(A[i, j]);
                    row.Add(A[i, j]);
                }
                matrix.Add(row);
            }


            return matrix;
        }
    }
}
