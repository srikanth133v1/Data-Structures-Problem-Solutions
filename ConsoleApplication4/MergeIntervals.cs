using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class MergeIntervals
    {
        public static void Merge(List<Interval> A)
        {
            //start falls between current start and end. Then take current start
            //end falls between current start and end. Then take current end
            //start doesn't between current start and end and next start and end. create new start
            //end doesn't fall between current start and end and next start end end. 
            Interval interval = new Interval();
            for (int i = 0; i < A.Count - 1; i++)
            {
                if (A[i].End <= interval.Start && A[i + 1].End <= interval.Start)
                {
                    continue;
                }


            }
        }
        public class Interval
        {
            public int Start { get; set; }
            public int End { get; set; }
        }
    }
}
