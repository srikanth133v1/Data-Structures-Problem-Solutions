using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class InOrderTraversal
    {
        public static List<int> Traverse(TreeNode A)
        {
            TreeNode temp = A;
            List<int> values = new List<int>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            bool isComplete = false;
            while (!isComplete)
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
                        isComplete = true;
                    }
                }
            }
            return values;

        }
    }
}
