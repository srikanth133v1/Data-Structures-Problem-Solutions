using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.LinkedLists
{
    public class ReverseList
    {
        public static ListNode Reverse(ListNode temp)
        {
            ListNode temp2 = temp;
            ListNode rev = null;
            while (temp2 != null)
            {
                ListNode next = temp2.next;
                temp2.next = rev;
                rev = temp2;
                temp2 = next;
            }
            return rev;
        }
    }
}
