using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.LinkedLists
{
    public class ReverseLinkListII
    {
        public static ListNode ReverseRange(ListNode A, int M, int N)
        {
            if (null == A || M < 1)
            {
                return A;
            }
            int length = GetLength(A);
            if (M > length || N > length || M > N)
            {
                return A;
            }
            int count = 1;
            ListNode temp2 = A, temp = A;

            ListNode prev = null;
            ListNode rev = null;

            while (temp2 != null && count < M)
            {
                prev = temp2;
                temp2 = temp2.next;
                count++;
            }

            if (temp == null && count < M)
            {
                return A;
            }

            ListNode revTail = temp2;
            rev = temp2;
            while (temp2 != null)
            {

                ListNode next = temp2.next;
                temp2.next = rev;
                rev = temp2;
                temp2 = next;

                if (count == N)
                {
                    break;
                }
                count++;

            }

            if (prev == null)
            {
                temp = rev;
            }
            else
            {
                prev.next = rev;
            }
            revTail.next = temp2;
            if (M == 0)
            {
                return rev;
            }
            return temp;
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
