using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class LeastCommonAncestor
    {
        public static bool FindPath(TreeNode root, int element, List<int> path)
        {
            if (root == null)
            {
                return false;
            }
            path.Add(root.val);
            if (root.val == element)
            {
                return true;
            }
            if(FindPath(root.left, element, path) || FindPath(root.right, element, path))
            {
                return true;
            }

            path.RemoveAt(path.Count - 1);
            return false;
        }

        public static int FindLCA(TreeNode A, int node1, int node2)
        {
            List<int> path1 = new List<int>();
            List<int> path2 = new List<int>();

            bool hasNode1 = FindPath(A, node1, path1);
            bool hasNode2 = FindPath(A, node2, path2);

            if (!hasNode1 || !hasNode2)
            {
                return -1;
            }
            else
            {
                int i = 0;
                for (; i < path1.Count && i < path2.Count; i++)
                {
                    if (path1[i] != path2[i])
                    {
                        break;
                    }
                }
                return path1[i - 1];
            }
        }

        //public static void Find(TreeNode A)
        //{
        //    List<NodeDepth> visited = new List<NodeDepth>();
        //    Stack<TreeNode> s = new Stack<TreeNode>();
        //    s.Push(A);

        //    int depth = 0;

        //    bool isComplete = false;
        //    TreeNode temp = A;
        //    while (!isComplete)
        //    {

        //        if (temp != null)
        //        {
        //            s.Push(temp);
        //            depth++;
        //            visited.Add(new NodeDepth()
        //            {
        //                Value = temp.val,
        //                Depth = depth
        //            });
        //            temp = temp.left;
        //        }
        //        else
        //        {
        //            if (s.Count > 0)
        //            {
        //                temp = s.Pop();
        //                if (temp.val != visited[visited.Count - 1].Value)
        //                {
        //                    depth--;

        //                    visited.Add(new NodeDepth()
        //                    {
        //                        Value = temp.val,
        //                        Depth = depth
        //                    });
        //                }
        //                temp = temp.right;
        //            }
        //            else
        //            {
        //                isComplete = true;
        //            }
        //        }
        //    }

        //    //while (s.Count > 0)
        //    //{
        //    //    TreeNode temp = s.Pop();
        //    //    visited.Add(new NodeDepth()
        //    //    {
        //    //        Value = temp.val,
        //    //        Depth = visited.Count == 0 ? 1 : visited[visited.Count - 1].Depth + 1
        //    //    });
        //    //    depth++;
        //    //    if (temp.right != null)
        //    //    {
        //    //        s.Push(temp.right);
        //    //    }
        //    //    if (temp.left != null)
        //    //    {
        //    //        s.Push(temp.left);
        //    //    }
        //    //    if (temp.left == null && temp.right == null)
        //    //    {
        //    //        visited.Add(visited[visited.Count - 1]);
        //    //    }
        //    //}
        //    foreach (var item in visited)
        //    {
        //        Console.WriteLine("Node: " + item.Value + " Depth: " + item.Depth);
        //    }

        //}

        //public class NodeDepth
        //{
        //    public int Value { get; set; }
        //    public int Depth { get; set; }
        //}
    }
}
