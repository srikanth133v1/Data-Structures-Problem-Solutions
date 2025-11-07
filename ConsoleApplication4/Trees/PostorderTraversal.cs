using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class PostorderTraversal
    {
        public static List<int> Traverse(TreeNode A)
        {
            List<int> lst = new List<int>();
            if (A == null)
            {
                return lst;
            }

            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(A);
            Stack<TreeNode> s2 = new Stack<TreeNode>();
            while (s.Count > 0)
            {
                TreeNode current = s.Pop();
                s2.Push(current);
                if (current.left != null)
                {
                    s.Push(current.left);
                }
                if (current.right != null)
                {
                    s.Push(current.right);
                }
            }

            while (s2.Count > 0)
            {
                TreeNode current = s2.Pop();
                lst.Add(current.val);
            }
            return lst;
        }
    }
}
