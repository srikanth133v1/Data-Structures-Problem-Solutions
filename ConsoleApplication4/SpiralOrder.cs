using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class SpiralOrder
    {
        public static List<int> spiralOrder(List<List<int>> A)
        {
            int t = 0, b = A.Count - 1, l = 0, r = A[0].Count - 1;
            int dir = 0;
            List<int> elements = new List<int>();
            while (t <= b && l <= r)
            {
                if (dir == 0)
                {
                    for (int i = l; i <= r; i++)
                    {
                        elements.Add(A[t][i]);
                        //Console.WriteLine(A[t][i]);
                    }
                    t++;
                    dir = 1;
                }
                else if (dir == 1)
                {
                    for (int i = t; i <= b; i++)
                    {
                        elements.Add(A[i][r]);
                    }
                    r--;
                    dir = 2;
                }
                else if (dir == 2)
                {
                    for (int i = r; i >= l; i--)
                    {
                        elements.Add(A[b][i]);
                    }
                    b--;
                    dir = 3;
                }
                else if (dir == 3)
                {
                    for (int i = b; i >= t; i--)
                    {
                        elements.Add(A[i][l]);
                    }
                    l++;
                    dir = 0;
                }
            }

            for (int i = 0; i < elements.Count; i++)
            {
                Console.WriteLine(elements[i]);
            }
            return elements;
        }
    }
}
