using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.LinkedLists
{
    public class ListCycle
    {
        public static ListNode Detect(ListNode A)
        {
            ListNode slow = A, fast = A;
            while (slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    return Remove(slow, A);
                }
            }
            return null;
        }

        public static ListNode Remove(ListNode slow, ListNode head)
        {
            ListNode x1 = head;
            ListNode x2 = null;


            while (true)
            {
                x2 = slow;
                while (x2.next != slow && x2.next != x1)
                {
                    x2 = x2.next;
                }

                if (x2.next == x1)
                {
                    break;
                }
                x1 = x1.next;
            }
            return x2.next;
        }
    }
}
