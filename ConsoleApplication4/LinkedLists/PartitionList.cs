using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.LinkedLists
{
    public class PartitionList
    {
        public static ListNode Partition(ListNode A, int B)
        {
            ListNode head = null;
            ListNode temp = A;
            ListNode greater = null;
            ListNode prevGreater = null;
            ListNode bNode = null;
            ListNode greaterStart = null;
            ListNode bNodeStart = null;
            ListNode prev = null;
            while (temp != null)
            {

                // Console.WriteLine(temp.val);
                if (temp.val > B)
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
                else if (temp.val == B)
                {
                    if (null != bNode)
                    {
                        bNode.next = temp;
                        bNode = bNode.next;

                        temp = temp.next;

                    }
                    else
                    {
                        bNodeStart = temp;
                        bNode = temp;
                        temp = temp.next;
                        bNode.next = null;
                    }

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

            if (bNodeStart == null)
            {
                bNodeStart = greaterStart;
            }

            // Console.WriteLine(prev.val);
            if (prev != null)
            {
                if (bNodeStart != null)
                {
                    prev.next = bNodeStart;
                }
                else if (greaterStart != null)
                {
                    prev.next = greaterStart;
                }
            }

            if (bNode != null)
            {
                bNode.next = greaterStart;
            }

            return (head == null) ? ((bNodeStart == null) ? greaterStart : bNodeStart) : head;
        }
    }
}
