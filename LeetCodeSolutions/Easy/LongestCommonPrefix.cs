using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class LongestCommonPrefix
    {
        public static void DisplaySolution()
        {
            Console.WriteLine(Solution(new string[] { "flower", "flow", "flight" }));
            Console.WriteLine(Solution(new string[] { "dog", "racecar", "car" }));
        }

        private static string Solution(string[] s)
        {
            if (s == null || s.Length == 0)
                return "";

            if (s.Length == 1)
                return s[0];

            int minLength = s[0].Length;
            char c;
            string res = "";

            for(int i = 1; i < s.Length; i++)
            {
                if (s[i].Length < minLength)
                    minLength = s[i].Length;
            }

            for(int i = 0; i < minLength; i++)
            {
                c = s[0][i];

                for(int j = 0; j < s.Length; j++)
                {
                    if (c != s[j][i])
                        return res;

                }

                res += c;
            }

            return res;
        }
    }
}
