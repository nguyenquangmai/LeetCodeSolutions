using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class RemoveDuplicatesFromSortedList
    {
        public static void DisplaySolution()
        {
            ListNode example1 = 
                new ListNode(1, new ListNode(1, new ListNode(2)));
            ListNode example2 = 
                new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3)))));

            ListNode ex1 = Solution(example1);
            ListNode ex2 = Solution(example2);

            while(ex1 != null)
            {
                Console.WriteLine(ex1.val);
                ex1 = ex1.next;
            }

            Console.WriteLine();

            while (ex2 != null)
            {
                Console.WriteLine(ex2.val);
                ex2 = ex2.next;
            }
        }

        private static ListNode Solution(ListNode head)
        {
            if(head == null)
                return null;

            ListNode r = head;

            while (r != null && r.next != null) 
            { 
                if(r.val == r.next.val)
                    r.next = r.next.next;
                else
                    r = r.next;
            }

            return head;
        }
    }
}
