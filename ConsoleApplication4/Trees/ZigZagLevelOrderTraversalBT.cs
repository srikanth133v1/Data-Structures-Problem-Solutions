using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class ZigZagLevelOrderTraversalBT
    {
        public static List<List<int>> Traverse(TreeNode A)
        {
            List<List<TreeNode>> levels = new List<List<TreeNode>>();
            List<List<int>> levelValues = new List<List<int>>();

            if (A == null)
            {
                return levelValues;
            }
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(A);

            bool zigZag = true;

            while (q.Count > 0)
            {
                List<TreeNode> level = new List<TreeNode>();
                List<int> levelValue = new List<int>();
                while (q.Count > 0)
                {
                    
                    TreeNode temp = q.Dequeue();
                    level.Add(temp);
                    levelValue.Add(temp.val);
                }
                zigZag = !zigZag;
                levels.Add(level);
                levelValues.Add(levelValue);
                for (int i = levels[levels.Count - 1].Count-1; i >=0; i--)
                {
                    if (zigZag)
                    {
                        if (levels[levels.Count - 1][i].left != null)
                        {
                            q.Enqueue(levels[levels.Count - 1][i].left);
                        }
                        if (levels[levels.Count - 1][i].right != null)
                        {
                            q.Enqueue(levels[levels.Count - 1][i].right);
                        }
                    }
                    else
                    {
                        if (levels[levels.Count - 1][i].right != null)
                        {
                            q.Enqueue(levels[levels.Count - 1][i].right);
                        }
                        if (levels[levels.Count - 1][i].left != null)
                        {
                            q.Enqueue(levels[levels.Count - 1][i].left);
                        }
                    }


                }
            }

            return levelValues;
        }
    }
}
