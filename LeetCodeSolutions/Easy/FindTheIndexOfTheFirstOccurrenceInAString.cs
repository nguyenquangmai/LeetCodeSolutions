using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class FindTheIndexOfTheFirstOccurrenceInAString
    {
        public static void DisplaySolution()
        {
            string haystack1 = "sadbutsad", needle1 = "sad";
            string haystack2 = "leetcode", needle2 = "leeto";
            string haystack3 = "hello", needle3 = "ll";

            Console.WriteLine(Solution(haystack1, needle1));
            Console.WriteLine(Solution(haystack2, needle2));
            Console.WriteLine(Solution(haystack3, needle3));
        }

        private static int SolutionPing0ms(string haystack, string needle)
        {
            if (haystack.Contains(needle))
            {
                int i = 0;
                while(haystack.Length > needle.Length && haystack.Substring(0, needle.Length) != needle)
                {
                    haystack = haystack.Substring(1, haystack.Length - 1);
                    i++;
                }

                return i;
            }

            return -1;
        }

        private static int Solution(string haystack, string needle)
        {
            for(int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    int temp = i;
                    string res = haystack[i].ToString();

                    for(int j = 1; j < needle.Length; j++)
                    {
                        if (temp + 1 < haystack.Length && haystack[temp + 1] == needle[j])
                        {
                            res += haystack[temp + 1];

                            if (res == needle)
                                return i;

                            temp++;
                        }
                    }

                    if (res == needle)
                        return i;
                }
            }

            return -1;
        }
    }
}
