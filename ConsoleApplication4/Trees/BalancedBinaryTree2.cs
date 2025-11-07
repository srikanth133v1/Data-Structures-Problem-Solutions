using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class BalancedBinaryTree2
    {
        public static int IsBalanced(TreeNode A, ref int height)
        {

            if (A == null)
            {
                height = 0;
                return 1;
            }

            int leftHeight = 0, rightHeight = 0;
            int isLeftBalanced = IsBalanced(A.left, ref leftHeight);
            int isRightBalanced = IsBalanced(A.right, ref rightHeight);
            int diff = Math.Abs(leftHeight - rightHeight);
            height = Math.Max(leftHeight, rightHeight) + 1;
            if (diff > 1)
            {
                return 0;
            }
            else
            {
                if (isLeftBalanced == 1 && isRightBalanced == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
