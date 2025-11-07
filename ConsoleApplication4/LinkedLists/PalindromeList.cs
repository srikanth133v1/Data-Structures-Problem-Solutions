using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.LinkedLists
{
    public class PalindromeList
    {
        public static int Check(ListNode A)
        {
            ListNode temp = A;
            Stack<ListNode> s = new Stack<ListNode>();
            while (temp != null)
            {
                s.Push(temp);
                temp = temp.next;
            }
            temp = A;
            while (temp != null)
            {
                ListNode top = s.Pop();
                if (top.val != temp.val)
                {
                    return 0;
                }
                temp = temp.next;
            }

            return 1;
        }

        public static int CheckBySplit(ListNode A)
        {
            int length = ListNodeUtil.GetLength(A);

            ListNode temp = A;
            ListNode midNode = null;
            int mid = length / 2;
            int count = 0;
            while (count < mid)
            {
                midNode = temp;
                temp = temp.next;
                count++;
            }


            ListNode revHead = ReverseList.Reverse(temp);
            //ListNodeUtil.Print(revHead);
            temp = A;
            ListNode revHeadTemp = revHead;
            count = 0;
            int res = 1;
            while (count < mid)
            {
                if (revHeadTemp.val != temp.val)
                {
                    res = 0;
                    break;
                }
                revHeadTemp = revHeadTemp.next;
                temp = temp.next;
                count++;
            }

            ListNode revRevHead = ReverseList.Reverse(revHead);
            //ListNodeUtil.Print(revRevHead);
            midNode.next = revRevHead;
            ListNodeUtil.Print(A);
            return res;
        }
    }
}
