using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class NextGreaterNumberBST
    {
        public static TreeNode FindNextMax(TreeNode A, int B)
        {
            TreeNode current = FindCurrent(A, B);

            if (null == current)
            {
                return current;
            }
            if (current.right != null)
            {
                return FindMin(current.right);
            }
            else
            {
                TreeNode successor = null;
                TreeNode ancestor = A;

                while (ancestor != current)
                {
                    if (ancestor.val > current.val)
                    {
                        successor = ancestor;
                        ancestor = ancestor.left;
                    }
                    else
                    {
                        ancestor = ancestor.right;
                    }

                }
                return successor;
            }

        }
        public static TreeNode FindMin(TreeNode A)
        {
            if (null == A)
            {
                return A;
            }
            TreeNode temp = A;
            while (temp.left != null)
            {
                temp = temp.left;
            }
            return temp;
        }
        public static TreeNode FindCurrent(TreeNode A, int data)
        {
            if (null == A)
            {
                return A;
            }
            if (A.val == data)
            {
                return A;
            }
            if (A.val > data)
            {
                return FindCurrent(A.left, data);
            }
            else
            {
                return FindCurrent(A.right, data);
            }
        }
    }
}
