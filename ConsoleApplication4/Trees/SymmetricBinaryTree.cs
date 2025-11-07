using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class SymmetricBinaryTree
    {
        public static int IsSymmetric(TreeNode A, TreeNode B)
        {
            if(A==null && B == null)
            {
                return 1;
            }

            if(A!=null && B!=null && A.val == B.val)
            {
                int left = IsSymmetric(A.left, B.right);
                int right= IsSymmetric(A.right, B.left);

                if (left == 1 && right == 1)
                {
                    return 1;
                }else
                {
                    return 0;
                }
            }
            return 0;
        }
    }
}
