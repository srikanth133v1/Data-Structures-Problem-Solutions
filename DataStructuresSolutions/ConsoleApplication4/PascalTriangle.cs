using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class PascalTriangle
    {
        public static List<List<int>> Print(int A)
        {

            List<List<int>> values = new List<List<int>>();
            if (A <= 0)
            {
                return values;
            }
            if (A >= 1)
            {
                values.Add(new List<int>() { 1 });
            }
            int total = 2;
            while (total <= A)
            {
                List<int> row = new List<int>();
                List<int> prevRow = values[values.Count - 1];
                //row.Add(total);
                for (int i = 0; i < prevRow.Count; i++)
                {
                    if (i == 0)
                    {
                        row.Add(prevRow[0]);
                    }
                    else
                    {
                        row.Add(prevRow[i] + prevRow[i - 1]);
                    }

                }
                row.Add(prevRow[0]);
                values.Add(row);
                total++;
            }

            foreach (var row in values)
            {
                foreach (var item in row)
                {
                    Console.WriteLine(item);
                }
            }
            return values;
        }

        //Zero based index
        public static List<int> KthRow(int A)
        {

            List<List<int>> values = new List<List<int>>();
            if (A < 0)
            {
                return new List<int>();
            }
            if (A >= 0)
            {
                values.Add(new List<int>() { 1 });
            }
            int total = 1;
            while (total <= A)
            {
                List<int> row = new List<int>();
                List<int> prevRow = values[values.Count - 1];
                //row.Add(total);
                for (int i = 0; i < prevRow.Count; i++)
                {
                    if (i == 0)
                    {
                        row.Add(prevRow[0]);
                    }
                    else
                    {
                        row.Add(prevRow[i] + prevRow[i - 1]);
                    }

                }
                row.Add(prevRow[0]);
                values.Add(row);
                total++;
            }

            foreach (var item in values[values.Count - 1])
            {
                Console.WriteLine(item);
            }
            return values[values.Count - 1];
        }
    }
}
