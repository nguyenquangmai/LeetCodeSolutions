using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class PalindromeNumber
    {
        public static void DisplaySolution()
        {
            int x1 = 121;
            int x2 = -121;
            int x3 = 10;

            Console.WriteLine(Solution(x1));
            Console.WriteLine(Solution(x2));
            Console.WriteLine(Solution(x3));
        }

        private static bool Solution(int x)
        {
            int r = 0, t = x;

            while (t > 0)
            {
                r = r * 10 + t % 10;
                t /= 10;
            }

            return r == x;
        }
    }
}
