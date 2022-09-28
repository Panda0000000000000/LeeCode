/***************************************************
	日期：2022/08/27  22:28
	作者：夏
	描述：给定两个字符串 s 和 t ，编写一个函数来判断 t 是否是 s 的字母异位词。
        注意：若 s 和 t 中每个字符出现的次数都相同，则称 s 和 t 互为字母异位词。

            //感觉这道题  也没有存在的意义    或者是一同了一种思考问题的思路            

****************************************************/


using System;
using System.Collections.Generic;

namespace _24有效的字母异位词
{
    class _24有效的字母异位词
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //排序
        public bool IsAnagram_1(string s, string t)
        {
            if (s.Length!=t.Length)
            {
                return false;
            }

            char[] s_Chars = s.ToCharArray();
            char[] t_Chars = t.ToCharArray();

            Array.Sort(s_Chars);
            Array.Sort(t_Chars);

            for (int i = 0; i < s.Length; i++)
            {
                char s_char = s_Chars[i];
                char t_char = t_Chars[i];

                if (s_char!=t_char)
                {
                    return false;
                }

            }

            return true;
        }
    }
}
