using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class SortedArrayToBalancedBST
    {
        public static TreeNode Construct(List<int> A)
        {
            return FindMid(A, 0, A.Count - 1);
        }

        public static TreeNode FindMid(List<int> A, int start, int end)
        {
            if (start > end)
            {
                return null;
            }
            int mid = (start + end) / 2;

            TreeNode root = new TreeNode() { val = A[mid] };
            root.left = FindMid(A, start, mid - 1);

            root.right = FindMid(A, mid + 1, end);
            return root;
        }
    }
}
