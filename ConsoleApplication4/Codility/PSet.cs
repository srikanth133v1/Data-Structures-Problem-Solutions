using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Codility
{
    public class PSet
    {
        //public static int maxSetSize(List<int> riceBags)
        //{
        //    if (null == riceBags || riceBags.Count <= 1)
        //    {
        //        return -1;
        //    }

        //    Dictionary<int, int> d = new Dictionary<int, int>();
        //    for (var i = 0; i < riceBags.Count; i++)
        //    {
        //        if (!d.ContainsKey(riceBags[i]))
        //        {
        //            d.Add(riceBags[i], riceBags[i]);
        //        }
        //    }
        //    int count = 0;
        //    int maxSoFar = 0;
        //    riceBags.Sort();
        //    for (var i = 0; i < riceBags.Count; i++)
        //    {
        //        if (d.ContainsKey(riceBags[i] * riceBags[i]))
        //        {
        //            count++;
        //        }
        //        else
        //        {
        //            count = 0;
        //        }
        //        if (maxSoFar < count)
        //        {
        //            maxSoFar = count;
        //        }
        //    }
        //    Console.WriteLine(string.Join(",", riceBags.ToArray()));
        //    return maxSoFar > 0 ? ++maxSoFar : -1;

        //}
        public static int maxSetSize(List<int> riceBags)
        {
            if (null == riceBags || riceBags.Count <= 1)
            {
                return -1;
            }

            Dictionary<int, int> d = new Dictionary<int, int>();
            for (var i = 0; i < riceBags.Count; i++)
            {
                if (!d.ContainsKey(riceBags[i]))
                {
                    d.Add(riceBags[i], riceBags[i]);
                }
            }
            
            int maxSoFar = 0;
            riceBags.Sort();
            for (var i = 0; i < riceBags.Count; i++)
            {
                var t = riceBags[i];
                int count = 0;
                while (d.ContainsKey(t) && t <= riceBags[riceBags.Count - 1])
                {
                    count++;
                    t = t * t;
                }
                
                if (maxSoFar < count)
                {
                    maxSoFar = count;
                }
            }
            Console.WriteLine(string.Join(",", riceBags.ToArray()));
            return maxSoFar > 0 ? ++maxSoFar : -1;

        }
    }
}
