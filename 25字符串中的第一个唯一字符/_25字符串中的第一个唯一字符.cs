/***************************************************
	日期：2022/08/27  22:23
	作者：夏
	描述：给定一个字符串 s ，找到 它的第一个不重复的字符，并返回它的索引 。如果不存在，则返回 -1 。
            不明白这道题的考点是什么
        1.暴力解法 如果这种解法是这道题的标准解法的话 ，那这道题就没有了他存在的意义
****************************************************/
using System;
using System.Collections.Generic;

namespace _25字符串中的第一个唯一字符
{
    class _25字符串中的第一个唯一字符
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FirstUniqChar("leetcode");
        }

        //暴力解法
        public static int FirstUniqChar(string s)
        {
            char[] chars = s.ToCharArray();
            Dictionary<int, int> cache_CharCount = new Dictionary<int, int>();
            for (int i = 0; i < s.Length; i++)
            {
                char a = chars[i];
                if (!cache_CharCount.ContainsKey(a))
                {
                    cache_CharCount.Add(a, 1);
                }
                else
                {
                    cache_CharCount[a]++;
                }
            }

            foreach (var item in cache_CharCount)
            {
                if (item.Value==1)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        char a = chars[i];
                        if (a==item.Key)
                        {
                            return i;
                        }
                    }
                }
            }

            return -1;
        }
    }
}
