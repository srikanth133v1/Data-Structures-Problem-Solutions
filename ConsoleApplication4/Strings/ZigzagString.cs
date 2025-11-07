using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Strings
{
    public class ZigzagString
    {
        public static string Zigzag(string a, int rows)
        {
            int i = 0, j = 0;
            StringBuilder sb = new StringBuilder();
            int currentRow = 0;



            while (currentRow < rows)
            {
                i = currentRow; j = currentRow;
                while (i < a.Length && j < a.Length)
                {
                    j = i + (rows - currentRow - 1) * 2;
                    if (i < a.Length)
                    {
                        sb.Append(a[i]);
                    }

                    if (j < i + (rows - 1) * 2 && j < a.Length && i != j)
                    {
                        sb.Append(a[j]);
                    }
                    i = i + (rows - 1) * 2;
                }
                currentRow += 1;
            }
            return sb.ToString();
        }
    }
}
