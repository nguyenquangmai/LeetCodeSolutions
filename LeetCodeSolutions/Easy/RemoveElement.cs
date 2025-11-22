using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class RemoveElement
    {
        public static void DisplaySolution()
        {
            int[] nums1 = new int[] { 3,2,2,3 };
            int[] nums2 = new int[] { 0,1,2,2,3,0,4,2 };

            Console.WriteLine(Solution(nums1, 3));
            Console.WriteLine();
            Console.WriteLine(Solution(nums2, 2));
        }

        private static int Solution(int[] nums, int val)
        {
            int res = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[res] = nums[i];
                    res++;
                }
            }
            
            return res;
        }
    }
}
