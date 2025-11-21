using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class MergeTwoSortedLists
    {
        public static void DisplaySolution()
        {
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            ListNode t = Solution(list1, list2);

            while(t != null)
            {
                Console.WriteLine(t.val);
                t = t.next;
            }
        }

        private static ListNode Solution(ListNode list1, ListNode list2)
        {
            ListNode r = new ListNode();
            ListNode t = r;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    t.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    t.next = list2;
                    list2 = list2.next;
                }

                t = t.next;
            }

            if (list1 != null)
                t.next = list1;
            else if (list2 != null)
                t.next = list2;

            return r.next;
        }
    }
}
