using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.LinkedLists
{
    public class ListNodeUtil
    {
        public static void Print(ListNode a)
        {
            ListNode temp = a;
            
            while (temp != null)
            {
                Console.WriteLine(temp.val);
                temp = temp.next;
            }
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
