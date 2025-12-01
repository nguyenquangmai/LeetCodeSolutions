using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class SameTree
    {
        public static void DisplaySolution()
        {
            TreeNode p1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            TreeNode q1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            Console.WriteLine(IsSameTree(p1, q1));

            TreeNode p2 = new TreeNode(1, new TreeNode(2), null);
            TreeNode q2 = new TreeNode(1, null, new TreeNode(2));
            Console.WriteLine(IsSameTree(p2, q2));

            TreeNode p3 = new TreeNode(1, new TreeNode(2), new TreeNode(1));
            TreeNode q3 = new TreeNode(1, new TreeNode(1), new TreeNode(2));
            Console.WriteLine(IsSameTree(p3, q3));
        }

        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;

            if (p == null || q == null)
                return false;

            if (p.val != q.val)
                return false;

            return IsSameTree(p.left, q.left)&& IsSameTree(p.right, q.right);
        }

        public static bool IsSameTreeQueue(TreeNode p, TreeNode q)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(p);
            queue.Enqueue(q);

            while(queue.Count > 0)
            {
                TreeNode node1 = queue.Dequeue();
                TreeNode node2 = queue.Dequeue();

                if (node1 == null && node2 == null) 
                    continue;

                if (node1 == null || node2 == null)
                    return false;

                if (node1.val != node2.val)
                    return false;

                queue.Enqueue(node1.left);
                queue.Enqueue(node2.left);

                queue.Enqueue(node1.right);
                queue.Enqueue(node2.right);
            }

            return true;
        }
    }
}
