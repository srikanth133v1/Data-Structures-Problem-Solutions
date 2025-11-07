using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.LinkedLists
{
    public class SUBTRACT
    {
        public static ListNode Cal(ListNode A)
        {
            if(null==A||A.next == null)
            {
                return A;
            }
            ListNode tempFirst = A;
            ListNode tempLast = A;
            int length = GetLength(A);

            for (int i = 0; i < length / 2; i++)
            {
                tempLast = tempLast.next;
            }

            ListNode rev = ReverseLinkListII.ReverseRange(tempLast, 1, length - (length/2));
            tempLast = rev;
            ListNode tempRev = rev;
            ListNode prev = A;
            for (int i = 0; i < length / 2; i++)
            {
                tempFirst.val = tempLast.val - tempFirst.val;
                prev = tempFirst;
                tempFirst = tempFirst.next;
                tempLast = tempLast.next;
            }

            rev = ReverseLinkListII.ReverseRange(tempRev, 1, length - (length / 2));

            prev.next = rev;
            return A;
        }

        public static int GetLength(ListNode a)
        {
            int count = 0;
            ListNode temp = a;

            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
    }
}
