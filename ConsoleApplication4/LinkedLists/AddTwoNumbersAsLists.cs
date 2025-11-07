using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.LinkedLists
{
    public class AddTwoNumbersAsLists
    {
        public static ListNode Add(ListNode A, ListNode B)
        {
            if (null == A && null == B)
            {
                return A;
            }
            if (null == A && null != B)
            {
                return A;
            }
            if (null != A && null == B)
            {
                return B;
            }

            int carry = 0;
            int sum = 0;
            ListNode lstSum = null;
            ListNode head = null;
            ListNode prev = null;
            while (A != null && B != null)
            {
                sum = (carry + A.val + B.val) % 10;
                carry = (carry + A.val + B.val) / 10;
                lstSum = new ListNode() { val = sum };
                if (head == null)
                {
                    head = lstSum;
                    prev = lstSum;
                }else
                {
                    prev.next = lstSum;
                    prev = prev.next;
                }

              
                lstSum = lstSum.next;
                A = A.next;
                B = B.next;
            }
            while (A != null)
            {
                sum = (carry + A.val) % 10;
                carry = (carry + A.val) / 10;
                lstSum = new ListNode() { val = sum };

                prev.next = lstSum;
                prev = prev.next;
                lstSum = lstSum.next;
                A = A.next;
            }
            while (B != null)
            {
                sum = (carry + B.val) % 10;
                carry = (carry + B.val) / 10;
                lstSum = new ListNode() { val = sum };

                prev.next = lstSum;
                prev = prev.next;
                lstSum = lstSum.next;
                B = B.next;
            }
            if (carry == 1)
            {
                lstSum = new ListNode() { val = 1 };
                prev.next = lstSum;
            }
            return head;
        }
    }
}
