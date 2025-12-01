using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class MergeSortedArray
    {
        public static void DisplaySolution()
        {
            int[] arr1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int[] arr2 = new int[] { 2, 5, 6 };

            int[] arr3 = new int[] { 1 };
            int[] arr4 = new int[] { };

            int[] arr5 = new int[] { 0 };
            int[] arr6 = new int[] { 1 };

            Solution(arr1, 3, arr2, 3);
            Solution(arr3, 1, arr4, 0);
            Solution(arr5, 0, arr6, 1);
        }

        private static void Solution(int[] nums1, int m, int[] nums2, int n)
        {
            int k = 0;
            int j = 0;

            for(int i = m; i < m + n; i++)
            {
                nums1[i] = nums2[k];
                k++;
            }

            SortArray(nums1);
        }

        private static void SortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }
}
