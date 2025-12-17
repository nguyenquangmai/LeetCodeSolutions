using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class MinimumDepthOfBinaryTree
    {
        public static void DisplaySolution()
        {
            TreeNode root1 = new TreeNode()
            {
                val = 3,
                left = new TreeNode()
                {
                    val = 9
                },
                right = new TreeNode()
                {
                    val = 20,
                    left = new TreeNode()
                    {
                        val = 15
                    },
                    right = new TreeNode()
                    {
                        val = 7
                    }
                }
            };

            TreeNode root2 = new TreeNode()
            {
                val = 2,
                right = new TreeNode()
                {
                    val = 3,
                    right = new TreeNode()
                    {
                        val = 4,
                        right = new TreeNode()
                        {
                            val = 5,
                            right = new TreeNode()
                            {
                                val = 6
                            }
                        }
                    }
                }
            };

            Console.WriteLine(MinDepth4ms(root1));
            Console.WriteLine(MinDepth4ms(root2));
        }

        private static int MinDepth0ms(TreeNode root)
        {
            if (root == null) return 0;

            Queue<TreeNode> que = new Queue<TreeNode>();
            que.Enqueue(root);
            int count = 1, depth = 1;

            while (que.Count > 0)
            {
                TreeNode node = que.Dequeue();
                count--;

                if (node.left == null && node.right == null) return depth;

                if (node.left != null)
                {
                    que.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    que.Enqueue(node.right);
                }

                if (count == 0)
                {
                    count = que.Count;
                    depth++;
                }
            }

            return depth;
        }

        private static int MinDepth4ms(TreeNode root)
        {
            if (root == null)
                return 0;

            if (root.left == null && root.right == null)
                return 1;

            int minDepth = int.MaxValue;
            
            if (root.left != null)
                minDepth = Math.Min(MinDepth4ms(root.left), minDepth);
            
            if (root.right != null)
                minDepth = Math.Min(MinDepth4ms(root.right), minDepth);
            
            return minDepth + 1;
        }

        private static int MinDepth1ms(TreeNode root)
        {
            if (root == null)
                return 0;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            
            queue.Enqueue(root);
            
            int depth = 1;
            
            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                for (int i = 0; i < levelSize; i++)
                {
                    TreeNode currentNode = queue.Dequeue();

                    if (currentNode.left == null && currentNode.right == null)
                        return depth;
                    
                    if (currentNode.left != null)
                        queue.Enqueue(currentNode.left);
                    
                    if (currentNode.right != null)
                        queue.Enqueue(currentNode.right);
                }
                depth++;
            }

            return depth;
        }
    }
}
