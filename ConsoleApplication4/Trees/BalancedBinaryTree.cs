using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class BalancedBinaryTree
    {
        public static bool IsBalanced(TreeNode A)
        {
            if (A == null)
            {
                return true;
            }

            int leftHeight = CalHeight(A.left);
            int rightHeight = CalHeight(A.right);
            int diff = Math.Abs(leftHeight - rightHeight);
            if (diff > 1)
            {
                return false;
            }
            else
            {
                return IsBalanced(A.left) && IsBalanced(A.right);
            }
        }

        public static int CalHeight(TreeNode A)
        {
            if (A == null)
            {
                return 0;
            }
            return Math.Max(CalHeight(A.left), CalHeight(A.right)) + 1;
        }
    }
}
