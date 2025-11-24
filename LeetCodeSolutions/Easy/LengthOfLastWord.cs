using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class LengthOfLastWord
    {
        public static void DisplaySolution()
        {
            Console.WriteLine(Solution("Hello World"));
            Console.WriteLine(Solution("   fly me   to   the moon  "));
            Console.WriteLine(Solution("luffy is still joyboy"));
        }

        private static int Solution2(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                var lastWord = s.Split(' ', StringSplitOptions.RemoveEmptyEntries).LastOrDefault();
                return lastWord != null ? lastWord.Length : 0;
            }
            return 0;
        }

        private static int Solution(string s)
        {
            if (s.Length == 0 || s == null)
                return 0;

            if (s.Length == 1)
                return 1;

            if (s.Length == 2 && s[1] == ' ')
                return 1;

            string temp = "";
            string res = s.Trim();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    temp = "";

                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[j] == ' ')
                            break;

                        temp += s[j];
                    }

                    if (res != temp && temp != "")
                        res = temp;
                }
            }

            Console.WriteLine(res);

            return res.Length;
        }
    }
}
