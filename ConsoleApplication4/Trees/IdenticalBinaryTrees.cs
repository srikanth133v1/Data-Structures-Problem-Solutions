using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class IdenticalBinaryTrees
    {
        public static bool IsIdentical(TreeNode A, TreeNode B)
        {
            if (A == null && B == null)
            {
                return true;
            }
            else if (A == null && B != null || A != null && B == null)
            {
                return false;
            }
            if (A.val != B.val)
            {
                return false;
            }
            return IsIdentical(A.left, B.left) && IsIdentical(A.right, B.right);
        }
    }
}
