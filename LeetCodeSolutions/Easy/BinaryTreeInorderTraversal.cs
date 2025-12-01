using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class  TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    internal class BinaryTreeInorderTraversal
    {
        public static void DisplaySolution()
        {
            TreeNode root1 = new TreeNode(1, null, new TreeNode(2, new TreeNode(3), null));
            TreeNode root2 = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5, new TreeNode(6), new TreeNode(7))), new TreeNode(3, null, new TreeNode(8, new TreeNode(9), null)));

            foreach (int val in InorderTraversalList(root1)) {
                Console.Write(val + " ");
            }

            Console.WriteLine();

            foreach (int val in InorderTraversalStack(root2))
            {
                Console.Write(val + " ");
            }
        }

        private static IList<int> InorderTraversalList(TreeNode root)
        {
            List<int> result = new List<int>();
            Inorder(root, result);
            return result;
        }

        private static void Inorder(TreeNode root, IList<int> result)
        {
            if (root == null)
                return;

            Inorder(root.left, result);
            result.Add(root.val);
            Inorder(root.right, result);
        }

        private static IList<int> InorderTraversalStack(TreeNode root)
        {
            TreeNode current = root;
            
            List<int> result = new List<int>();
            
            Stack<TreeNode> stack = new Stack<TreeNode>();

            while(current != null || stack.Count > 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }

                current = stack.Pop();
                result.Add(current.val);
                current = current.right;
            }

            return result;
        }
    }
}
