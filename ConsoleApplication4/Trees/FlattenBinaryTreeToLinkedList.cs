using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class FlattenBinaryTreeToLinkedList
    {
        public static void Flatten(TreeNode A)
        {
            TreeNode root = A;
            Stack<TreeNode> s = new Stack<TreeNode>();
            while (root != null || s.Count > 0)
            {
                if (root.right != null)
                {
                    s.Push(root.right);
                }
                if (root.left != null)
                {
                    root.right = root.left;
                    root.left = null;
                }
                else if (s.Count > 0)
                {
                    TreeNode temp = s.Pop();
                    root.right = temp;
                }
                root = root.right;
            }


        }
    }
}
