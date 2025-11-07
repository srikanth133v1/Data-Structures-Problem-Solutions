using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class ValidBinarySearchTree
    {
        public static bool IsValidBST(TreeNode A)
        {
            return IsBSTUtil(A, Int32.MinValue, Int32.MaxValue);
        }
        public static bool IsBSTUtil(TreeNode A, int min, int max)
        {
            if (A == null)
            {
                return true;
            }

            if (A.val > min && A.val < max)
            {
                return IsBSTUtil(A.left, min, A.val) && IsBSTUtil(A.right, A.val, max);

            }
            return false;
        }
    }

}
