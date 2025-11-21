using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class RemoveduplicatesFromSortedArray
    {
        public static void DisplaySolution()
        {
            Console.WriteLine(RemoveDuplicates(new int[] { 1,1,2 }));
            Console.WriteLine(RemoveDuplicates(new int[] { 0,0,1,1,1,2,2,3,3,4 }));
        }

        private static int RemoveDuplicates(int[] nums)
        {
            if(nums.Length == 0)
                return 0;
            if (nums.Length == 1)
                return 1;
            
            int index = 1;
            
            for (int i = 0; i < nums.Length - 1; i++) 
            {
                if (nums[i] != nums[i + 1])
                {
                    nums[index] = nums[i + 1];
                    index++;
                }
            }

            return index;
        }
    }
}
