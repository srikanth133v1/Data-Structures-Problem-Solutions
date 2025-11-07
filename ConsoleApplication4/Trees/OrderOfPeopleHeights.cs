using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class OrderOfPeopleHeights
    {
        public static List<int> Cal(List<int> A, List<int> B)
        {
            List<ONode> people = new List<ONode>();
            for (int i = 0; i < A.Count; i++)
            {
                people.Add(new ONode() { Height = A[i], Infront = B[i] });
            }

            people.Sort((l, r) => { return l.Height - r.Height; });
            List<int> actualOrder1 = new List<int>();
            int[] actualOrder = new int[people.Count];
            //for (int i = 0; i < people.Count; i++)
            //{
            //    actualOrder.Add(-1);
            //}
            for (int j = 0; j < people.Count; j++)
            {
                int idx = people[j].Infront;
                int count = 0, idx2 = 0;
                for (int k = 0; k < people.Count; k++)
                {
                    if (idx == 0)
                    {
                        if (actualOrder[k] == 0)
                        {
                            idx2 = k;
                            break;
                        }
                    }
                    else
                    {
                        if (actualOrder[k] == 0 || actualOrder[k] > people[j].Height)
                        {
                            count++;
                        }
                        if (count == idx)
                        {
                            idx2 = k + 1;
                            break;
                        }
                    }
                }
                while (actualOrder[idx2] > 0)
                {
                    idx2++;
                }
                actualOrder[idx2] = people[j].Height;
            }
            return actualOrder.ToList();
        }
    }

    public class ONode
    {
        public int Height;
        public int Infront;
    }
}
