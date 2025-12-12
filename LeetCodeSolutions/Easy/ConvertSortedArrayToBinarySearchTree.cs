using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class ConvertSortedArrayToBinarySearchTree
    {
        public static void DisplaySolution()
        {
            int[] arr1 = new int[] { -10, -3, 0, 5, 9 };
            int[] arr2 = new int[] { 1, 3 };

            TreeNode? bts1 = SortedArrayToBST(arr1);
            TreeNode? bts2 = SortedArrayToBST(arr2);
        }

        private static TreeNode? SortedArrayToBST(int[] nums)
        {
            return BuildBinarySearchTree(nums, 0, nums.Length - 1);
        }

        private static TreeNode BuildBinarySearchTree(int[] nums, int left, int right)
        {
            if (left > right)
                return null;

            int mid = left + (right - left) / 2;

            TreeNode node = new TreeNode(nums[mid]);

            Console.Write(node.val);

            node.left = BuildBinarySearchTree(nums, left, mid - 1);
            node.right = BuildBinarySearchTree(nums, mid + 1, right);

            return node;
        }
    }
}
