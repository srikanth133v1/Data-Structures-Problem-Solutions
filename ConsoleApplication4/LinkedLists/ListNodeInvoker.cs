using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.LinkedLists
{
    public class ListNodeInvoker
    {
        public static void Invoke()
        {
            ListNode A = new ListNode();
            A.val = 1;
            A.next = new ListNode()
            {
                val = 3,
                next = new ListNode()
                {
                    val = 3,
                    // next = null
                    next = new ListNode()
                    {
                        val = 4,
                        //next = null
                        next = new ListNode()
                        {
                            val = 5,
                            next = new ListNode()
                            {
                                val = 6,
                                next = null
                            }
                        }
                    }
                }
            };

            //ListNode a = RemoveNthNodeFromListEnd.Remove(A, 2);
            //ListNode a = RotateList.Rotate(A, 0);
            //ListNode B = new ListNode() { val = 1 };
            //ListNode a = AddTwoNumbersAsLists.Add(A, B);

            // int a = PalindromeList.CheckBySplit(A);

            // ListNode a = PartitionList.Partition(A, 2);

            //ListNode a = ReverseLinkListII.ReverseRange(A, 6, 4);
            ListNode a = SUBTRACT.Cal(A);
            ListNodeUtil.Print(a);
        }
    }
}
