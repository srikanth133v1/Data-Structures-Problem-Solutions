using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Strings
{
    public class ColumnMajorStr
    {
        public static string ColMajor(string[] arr)
        {
            int maxL = Int32.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (maxL < arr[i].Length)
                {
                    maxL = arr[i].Length;
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int col = 0; col < maxL; col++)
            {
                Console.WriteLine("col: "+col);
                for (int row = 0; row < arr.Length; row++)
                {
                    if(col >= arr[row].Length)
                    {
                        continue;
                    }
                    Console.WriteLine("row: "+row + ": "+arr[row][col]);
                    sb.Append(arr[row][col]);
                }
            }
            return sb.ToString();
        }
    }
}
