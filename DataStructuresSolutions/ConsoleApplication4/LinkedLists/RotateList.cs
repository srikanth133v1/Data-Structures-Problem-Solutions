using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.LinkedLists
{
    public class RotateList
    {
        public static ListNode Rotate(ListNode A, int B)
        {
            if (B <= 0)
            {
                return A;
            }

            ListNode moverA = A;
            ListNode moverB = A;
            ListNode head = A;

            int length = GetLength(A);
            B = B % length;
            //Console.WriteLine("B" + B);

            while (B > 0 && moverA != null)
            {
                moverA = moverA.next;
                B--;

            }

            if (moverA == null)
            {
                return A;
            }

            while (moverA.next != null)
            {
                moverA = moverA.next;

                moverB = moverB.next;
            }
            moverA.next = head;

            head = moverB.next;
            moverB.next = null;
            return head;
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
