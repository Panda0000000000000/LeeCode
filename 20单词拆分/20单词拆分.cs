using System;
using System.Collections.Generic;
using System.Data.Common;

namespace _20单词拆分
{
    class _20单词拆分
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WordBreak_S("leetcode", new List<string> { "le", "et", "code" });
        }

        public static bool WordBreak_S(string s, List<string> wordDict)
        {
            int len = s.Length;
            bool[] dp = new bool[len + 1];
            dp[0] = true;

            for (int i = 0; i < len; i++)
            {
                if (dp[i])
                {
                    for (int j = i + 1; j <= len; j++)
                    {
                        string s_Sub = s.Substring(i, j - i);
                        if (wordDict.Contains(s_Sub))
                        {
                            dp[i] = true;
                            if (dp[len])
                            {
                                return true;    
                            }
                        }
                    }
                }
            }

            return dp[len];
        }

        //动态规划
        public static bool WordBreak_1(string s, IList<string> wordDict)
        {
            var wordDictSet = new HashSet<string>(wordDict);

            bool[] dp = new bool[s.Length + 1];
            dp[0] = true;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    string str_Sub = s.Substring(i, j - i);
                    if (dp[i] && wordDictSet.Contains(str_Sub))
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