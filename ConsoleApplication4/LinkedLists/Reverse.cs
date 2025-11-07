using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.LinkedLists
{
    public class ReverseList
    {
        public static ListNode Reverse(ListNode lst)
        {
            ListNode temp = lst;
            ListNode rev = null;
            while (temp != null)
            {
                ListNode next = temp.next;
                temp.next = rev;
                rev = temp;
                temp = next;
            }
            return rev;
        }
    }
}
