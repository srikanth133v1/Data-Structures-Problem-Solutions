using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.LinkedLists
{
    public class MergeTwoSortedLists
    {
        public static ListNode Merge(ListNode A, ListNode B)
        {
            ListNode temp = null;
            ListNode head = null;


            while (A != null && B != null)
            {
                if (A.val < B.val)
                {

                    temp = A;
                    A = A.next;

                }
                else if (A.val > B.val)
                {
                    temp = B;
                    B = B.next;
                }
                else
                {
                    temp = A;
                    A = A.next;
                    B = B.next;
                }
                if (head == null)
                {
                    head = temp;
                }
                temp = temp.next;
            }

            if (A != null)
            {
                temp.next = A;
            }
            if (B != null)
            {
                temp.next = B;
            }


            return head;
        }
    }
}
