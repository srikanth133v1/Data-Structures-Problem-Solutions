using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class MinDepthOfBinaryTree
    {
        public static int FindMinDepth(TreeNode A)
        {
            if (A == null)
            {
                return 0;
            }

            return Math.Min(FindMinDepth(A.left), FindMinDepth(A.right)) + 1;
        }
    }
}
