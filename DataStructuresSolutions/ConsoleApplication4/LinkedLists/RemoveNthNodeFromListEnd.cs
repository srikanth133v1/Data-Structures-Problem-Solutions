using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.LinkedLists
{
    public class RemoveNthNodeFromListEnd
    {
        public static ListNode Remove(ListNode A, int B)
        {
            ListNode moverA = A;
            ListNode moverB = A;
            while (B > 0 && moverA != null)
            {

                Console.WriteLine("moverA.val: " + moverA.val);
                moverA = moverA.next;
                B--;
            }

            if (moverA == null)
            {
                // head needs to be removed
                return A.next;
            }

            ListNode previous = null;
            while (moverA != null)
            {
                Console.WriteLine("moverB.val: " + moverB.val);
                moverA = moverA.next;
                previous = moverB;
                moverB = moverB.next;
            }

            previous.next = moverB.next;

            return A;

            if (null == A)
            {
                return A;
            }
            int length = GetLength(A);


            ListNode temp = A;
            ListNode prev = null;
            if (B <= 0)
            {
                return A;
            }
            if (B < length)
            {
                int fromStart = length - B - 1;
                while (fromStart >= 0)
                {
                    // Console.WriteLine(temp.val);
                    prev = temp;
                    temp = temp.next;
                    fromStart--;
                }
                prev.next = temp.next;
            }
            else
            {
                A = A.next;
            }
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
