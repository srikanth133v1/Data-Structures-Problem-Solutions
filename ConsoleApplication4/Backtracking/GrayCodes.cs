using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Backtracking
{
    public class GrayCodes
    {
        public static void Generate(int A)
        {
            Arrange(A, null, 1, new List<int>() { 0, 1 }, new List<int>() { 1, 0 });
        }
        public static void Arrange(int A, List<int> codes, int len, List<int> l1, List<int> l2)
        {
            while (len < A)
            {
                for (int i = 0; i < l1.Count; i++)
                {
                    l1[i] = l1[i];
                }

                for (int i = 0; i < l2.Count; i++)
                {
                    l2[i] = (1 << len) + l2[i];
                }
                l2.Reverse();
                l1.AddRange(l2);
                l2 = new List<int>(l1);
                len++;
            }

            //l1.AddRange(l2);
            foreach (var item in l1)
            {
                Console.WriteLine(item);
            }
        }
        public static int PowerOfThwo(int power)
        {
            return 1 << power;
        }
    }
}
