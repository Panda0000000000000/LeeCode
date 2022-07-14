using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace 最长回文子串
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LongestPalindrome("a");

            Console.ReadKey();
        }

        public static string LongestPalindrome(string s)
        {
            StringBuilder stringBuilder = new StringBuilder();
            StringBuilder stringBuilder_Cache = new StringBuilder();
            string str_Resault="";

            Dictionary<char, int> dic_Now = new Dictionary<char, int>();
            Dictionary<char, int> dic_Now_CacheBuilderIndex = new Dictionary<char, int>();

            char[] s_Chars = s.ToCharArray();
            for (int int_Currindex = 0; int_Currindex < s_Chars.Length; int_Currindex++)
            {
                if (stringBuilder[0] == s_Chars[int_Currindex])
                {
                    stringBuilder.Append(s_Chars[int_Currindex]);

                    stringBuilder_Cache = stringBuilder_Cache.Length < stringBuilder.Length ? stringBuilder : stringBuilder_Cache;
                    str_Resault = stringBuilder_Cache.ToString();



                    if (stringBuilder[0] == s_Chars[int_Currindex])
                    {
                    }
                    else
                    {
                        int int_Index_Start = dic_Now_CacheBuilderIndex[s_Chars[int_Currindex]];
                        stringBuilder = stringBuilder.Remove(0,int_Index_Start);

                        stringBuilder_Cache = stringBuilder_Cache.Length < stringBuilder.Length ? stringBuilder : stringBuilder_Cache;
                        str_Resault = stringBuilder_Cache.ToString();
                    }


                    stringBuilder.Clear();
                    int_Currindex = dic_Now[s_Chars[int_Currindex]]+1;
                    dic_Now.Clear();
                    dic_Now_CacheBuilderIndex.Clear();
                }
                else
                {
                    dic_Now.Add(s_Chars[int_Currindex], int_Currindex);
                    stringBuilder.Append(s_Chars[int_Currindex]);
                    dic_Now_CacheBuilderIndex.Add(s_Chars[int_Currindex], stringBuilder.Length - 1);
                }
            }

            if (str_Resault=="")
            {
                str_Resault = stringBuilder[0].ToString();
            }

            return str_Resault;
        }
    }
}