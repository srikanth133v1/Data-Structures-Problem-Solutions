using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class MaxDepthOfBinaryTree
    {
        public static int FindMaxDepth(TreeNode A)
        {
            if (A == null)
            {
                return 0;
            }

            return  Math.Max(FindMaxDepth(A.left), FindMaxDepth(A.right)) + 1;
        }
    }


}
