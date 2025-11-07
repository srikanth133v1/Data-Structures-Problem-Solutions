using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class PreOrderTraversal
    {

        public static List<int> Traverse(TreeNode A)
        {
            if (A == null)
            {
                return new List<int>();
            }
            List<int> lst = new List<int>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(A);
            while (s.Count > 0)
            {
                TreeNode node = s.Pop();
                lst.Add(node.val);
                if (node.right != null)
                {
                    s.Push(node.right);
                }
                if (node.left != null)
                {
                    s.Push(node.left);
                }
            }



            return lst;
        }

    }
} 
