using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class InvertTheBinaryTree
    {
        public static void Invert(TreeNode A)
        {
            if (A == null)
            {
                return;
            }
            TreeNode temp = A.left;
            A.left = A.right;
            A.right = temp;
            Invert(A.left);
            Invert(A.right);
        }
    }
}
