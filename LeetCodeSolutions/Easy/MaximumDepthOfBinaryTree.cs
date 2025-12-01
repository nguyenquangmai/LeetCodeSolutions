using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class MaximumDepthOfBinaryTree
    {
        public static void DisplaySolution()
        {
            TreeNode root1 = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            TreeNode root2 = new TreeNode(1, null, new TreeNode(2));

            Console.WriteLine(MaxDepth(root1));
            Console.WriteLine(MaxDepth(root2));
        }

        private static int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }
    }
}
