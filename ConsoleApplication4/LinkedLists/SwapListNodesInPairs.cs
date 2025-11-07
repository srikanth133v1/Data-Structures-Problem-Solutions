using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.LinkedLists
{
    public class SwapListNodesInPairs
    {
        public static ListNode Swap(ListNode B)
        {
            ListNode A = new ListNode();
            A.val = 1;
            A.next = null;
            A.next = new ListNode()
            {
                val = 2,
                next = null
                //next = new ListNode()
                //{
                //    val = 3,
                //    next = new ListNode()
                //    {
                //        val = 4,
                //        next = new ListNode()
                //        {
                //            val = 5,
                //            next = new ListNode()
                //            {
                //                val = 6,
                //                next = null
                //            }
                //        }
                //    }
                //}
            };

            ListNode temp = A;
            ListNode temp2 = A.next;
            ListNode prev = null;
            if (temp2 == null)
            {
                return temp;
            }
            while (temp != null)
            {
                //if (temp.next != null && temp.next.next != null && temp.next.next.next != null)
                if (temp.next != null)
                {
                    //ListNode temp3 = temp.next.next;//3
                    //ListNode temp5 = temp3.next.next;

                    ListNode next = temp.next.next;//3, 5
                    ListNode current = temp.next;
                    temp.next.next = temp;//2->1, 4->3
                    temp.next = next;//1->3, 3->5
                    if (prev != null)
                    {
                        prev.next = current;

                    }
                    prev = temp;//1
                    //temp.next = temp3.next;//1-4

                    //temp3.next.next = temp3;//4-3
                    //temp3.next = temp5;//3-5
                    temp = temp.next;//3
                }
                else
                {
                    temp = temp.next;
                }
            }


            while (temp2 != null)
            {
                Console.WriteLine(temp2.val + " -> ");
                temp2 = temp2.next;
            }

            return temp2;

        }
    }
}
