using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class PlusOne
    {
        public static void DisplaySolution()
        {
            int[] a1 = Solution(new int[] { 1,2,3 });
            int[] a2 = Solution(new int[] { 4,3,2,1 });
            int[] a3 = Solution(new int[] { 9 });
            int[] a4 = Solution(new int[] { 9,8,7,6,5,4,3,2,1,0 });
            int[] a5 = Solution(new int[] { 9,9 });


            foreach (int i in a1)
                Console.WriteLine(i);

            Console.WriteLine();
            foreach (int i in a2)
                Console.WriteLine(i);

            Console.WriteLine();
            foreach (int i in a3)
                Console.WriteLine(i);

            Console.WriteLine();
            foreach (int i in a4)
                Console.WriteLine(i);

            Console.WriteLine();
            foreach (int i in a5)
                Console.WriteLine(i);
        }

        private static int[] Solution(int[] digits)
        {
            char[] chars = new char[digits.Length];

            for(int i = 0; i < digits.Length; i++)
            {
                chars[i] = (char) (digits[i] + '0');
            }

            for(int i = chars.Length - 1; i >= 0; i--)
            {
                int n = chars[i] - '0';

                if (n + 1 < 10)
                {
                    chars[i] = (char) (n + 1 + '0');
                    break;
                }
                else
                {
                    chars[i] = '0';

                    if (i == 0)
                    {
                        int[] r = new int[chars.Length + 1];

                        r[0] = 1;

                        return r;
                    }
                }
            }

            int[] arr = new int[chars.Length];
            for(int i = 0; i < chars.Length; i++)
            {
                arr[i] = chars[i] - '0';
            }

            return arr;
        }
    }
}
