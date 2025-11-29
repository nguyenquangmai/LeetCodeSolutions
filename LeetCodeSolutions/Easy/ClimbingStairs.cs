using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class ClimbingStairs
    {
        public static void DisplaySolution()
        {
            Console.WriteLine(Solution(2));
            Console.WriteLine(Solution(3));
            Console.WriteLine(Solution(4));
            Console.WriteLine(Solution(5));
            Console.WriteLine(Solution(6));
        }

        private static int Solution(int n)
        {
            if (n <= 3)
                return n;

            int f1 = 3;
            int f2 = 2;
            int res = 0;

            for(int i = 4; i <= n; i++)
            {
                res = f1 + f2;
                f2 = f1;
                f1 = res;
            }

            return res;
        }
    }
}
