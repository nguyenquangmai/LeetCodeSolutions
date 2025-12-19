using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class PathSum
    {
        public static void DisplaySolution()
        {
            int target1 = 22;
            TreeNode root1 = new TreeNode(5,
                                        new TreeNode(4,
                                            new TreeNode(11,
                                                new TreeNode(7),
                                                new TreeNode(2))),
                                        new TreeNode(8,
                                            new TreeNode(13),
                                            new TreeNode(4,
                                                new TreeNode(1))));

            int target2 = 5;
            TreeNode root2 = new TreeNode(1,
                                        new TreeNode(2),
                                        new TreeNode(3));

            int target3 = 0;
            TreeNode? root3 = null;

            int target4 = 1;
            TreeNode root4 = new TreeNode(1);

            int target5 = 1;
            TreeNode root5 = new TreeNode(1, new TreeNode(2));

            Console.WriteLine("Example 1 : " +  IsPathSum1ms(root1, target1));
            Console.WriteLine("Example 2 : " +  IsPathSum1ms(root2, target2));
            Console.WriteLine("Example 3 : " +  IsPathSum1ms(root3, target3));
            Console.WriteLine("Example 3 : " +  IsPathSum1ms(root4, target4));
            Console.WriteLine("Example 3 : " +  IsPathSum1ms(root5, target5));
        }

        private static bool IsPathSum1ms(TreeNode? root, int targetSum)
        {
            if (root == null)
                return false;

            if (root.left == null && root.right == null && root.val == targetSum)
                return true;

            Stack<int> stackNodeValues = new Stack<int>();
            Stack<TreeNode> stackNode = new Stack<TreeNode>();

            stackNode.Push(root);
            stackNodeValues.Push(root.val);

            while (stackNode.Count > 0)
            {
                TreeNode currentNode = stackNode.Pop();
                int sum = stackNodeValues.Pop();

                if(currentNode.left == null 
                    && currentNode.right == null 
                    && targetSum == sum)
                {
                    return true;
                }

                if(currentNode.left != null)
                {
                    stackNode.Push(currentNode.left);
                    stackNodeValues.Push(sum + currentNode.left.val);
                }

                if(currentNode.right != null)
                {
                    stackNode.Push(currentNode.right);
                    stackNodeValues.Push(sum + currentNode.right.val);
                }
            }

            return false;
        }
    }
}
