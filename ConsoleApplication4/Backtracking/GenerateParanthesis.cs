using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Backtracking
{
    public class GenerateParanthesis
    {
        public static void Generate(int A)
        {

            List<string> coll = new List<string>();
            char[] temp = new char[A * 2];
            Start(A, temp, 0, 0, 0, coll);
            foreach (var item in coll)
            {
                Console.WriteLine(item);
            }

        }
        public static void Start(int A, char[] temp, int pos, int open, int close, List<string> coll)
        {
            if (close == A)
            {
                coll.Add(string.Join("", temp));
                return;
            }
            else
            {
                if (open > close)
                {
                    temp[pos] = '}';
                    Start(A, temp, pos + 1, open, close + 1, coll);
                }
                if (open < A)
                {
                    temp[pos] = '{';
                    Start(A, temp, pos + 1, open + 1, close, coll);
                }
            }

        }
    }
}
