using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class MergeOverlappingIntervals
    {
        public static List<Interval> Overlap(List<Interval> A)
        {
            if (null == A || A.Count == 0)
            {
                return A;
            }
            A.Sort();
            Stack<Interval> temp = new Stack<Interval>();
            temp.Push(A[0]);

            for (int i = 1; i < A.Count; i++)
            {
                Interval top = temp.Peek();
                if (top.End < A[i].Start)
                {
                    temp.Push(A[i]);
                }
                else if (top.End < A[i].End)
                {
                    top.End = A[i].End;

                    temp.Pop();
                    temp.Push(top);
                }
            }
            A = temp.ToList<Interval>();
            A.Reverse();
            foreach (var item in A)
            {
                Console.WriteLine(item.Start + " " + item.End);
            }
            return A;
        }
    }

    public class Interval : IComparable
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Interval(int start, int end)
        {
            Start = start;
            End = end;
        }

        public int CompareTo(object obj)
        {
            Interval right = obj as Interval;
            if (Start == right.Start && End == right.End)
            {
                return 0;
            }
            if (Start > right.Start || Start > right.Start)
            {
                return 1;
            }

            if (End < right.Start || Start < right.Start)
            {
                return -1;
            }

            if (Start == right.Start && End < right.End)
            {
                return -1;
            }
            if (Start == right.Start && End > right.End)
            {
                return 1;
            }

            return -1;

        }
    }
}
