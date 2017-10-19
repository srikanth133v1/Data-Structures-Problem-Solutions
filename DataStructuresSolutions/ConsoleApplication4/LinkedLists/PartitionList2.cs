using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.LinkedLists
{
    public class PartitionList2
    {
        public static ListNode Partition(ListNode A, int B)
        {
            ListNode head = null;
            ListNode temp = A;
            ListNode greater = null;
            ListNode prevGreater = null;
            ListNode greaterStart = null;
            ListNode prev = null;
            while (temp != null)
            {

                // Console.WriteLine(temp.val);
                if (temp.val >= B)
                {
                    greater = temp;

                    temp = temp.next;
                    greater.next = null;
                    if (null == prevGreater)
                    {
                        greaterStart = greater;
                        prevGreater = greater;
                    }
                    else
                    {
                        prevGreater.next = greater;
                        prevGreater = prevGreater.next;
                    }
                    greater = greater.next;
                }
                else
                {
                    if (head == null)
                    {
                        head = temp;
                        prev = temp;
                    }
                    else
                    {
                        prev.next = temp;
                        prev = prev.next;
                    }


                    temp = temp.next;
                }

            }


            // Console.WriteLine(prev.val);
            if (prev != null)
            {
                if (greaterStart != null)
                {
                    prev.next = greaterStart;
                }
            }

            return (head == null) ? greaterStart : head;
        }
    }
}
