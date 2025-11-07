using ConsoleApplication4.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.DynamicProgramming
{
    public class MaxSumPathInBinaryTree
    {

        public int maxPathSum(TreeNode A)
        {
            int result = int.MinValue;

            FindMaxPath(A, ref result);

            return result;
        }

        public static int FindMaxPath(TreeNode root, ref int res)
        {
            if (null == root)
            {
                return 0;
            }

            int lMax = FindMaxPath(root.left, ref res);
            int rMax = FindMaxPath(root.right, ref res);

            int maxSingle = Math.Max(Math.Max(lMax, rMax) + root.val, root.val);

            int maxTop = Math.Max(maxSingle, lMax + root.val + rMax);

            res = Math.Max(res, maxTop);

            return maxSingle;

        }
    }


}
