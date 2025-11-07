using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class KthSmallestElementInTree
    {
        public static int Find(TreeNode A, int B)
        {
            TreeNode temp = A;
            Stack<TreeNode> s = new Stack<TreeNode>();
            List<int> values = new List<int>();
            while (values.Count < B)
            {
                if (temp != null)
                {
                    s.Push(temp);
                    temp = temp.left;
                }
                else
                {
                    if (s.Count > 0)
                    {
                        temp = s.Pop();
                        values.Add(temp.val);
                        temp = temp.right;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return values[values.Count - 1];
        }

    }
}
