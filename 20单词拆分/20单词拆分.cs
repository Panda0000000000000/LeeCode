using System;
using System.Collections.Generic;

namespace _20单词拆分
{
    class _20单词拆分
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WordBreak_1("leetcode", new List<string> { "le","et", "code" });
        }

        public static bool WordBreak_S(string s, List<string> wordDict)
        {
            var wordDictSet = new HashSet<string>(wordDict);

            var dp = new bool[s.Length + 1];
            dp[0] = true;
            for (int i = 1; i <= s.Length; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    if (dp[j]&&wordDictSet.Contains(s.Substring(j,i-j)))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[s.Length];
        }

        //动态规划
        public static bool WordBreak_1(string s, IList<string> wordDict)
        {
            var wordDictSet = new HashSet<string>(wordDict);

            bool[] dp = new bool[s.Length + 1];
            dp[0] = true;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i+1; j<s.Length; j++)
                {
                    string str_Sub = s.Substring(i, j - i);
                    if (dp[i]&&wordDictSet.Contains(str_Sub))
                    {
                        dp[j] = true;
                        break;
                    }
                }
            }

            return dp[s.Length];
        }
    }
}