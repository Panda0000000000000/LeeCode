using System;
using System.Collections.Generic;
using System.IO;

namespace 无重复字符的最长子串
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string a_Str = "au";
            int a = LengthOfLongestSubstring(a_Str);

            Console.WriteLine(LengthOfLongestSubstring(a_Str));
            Console.ReadKey();
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int count = 0;
            if (s.Length==0||s==null)
            {
                return count;
            }

            int len = s.Length;
            int int_MaxCount = 0;

            Dictionary<char, int> directory = new Dictionary<char, int>();
            
            char[] s_Arr = s.ToCharArray();
            for (int int_CurrentIndex = 0; int_CurrentIndex < len; int_CurrentIndex++)
            {
                if (!directory.ContainsKey(s_Arr[int_CurrentIndex]))
                {
                    directory.Add(s_Arr[int_CurrentIndex], int_CurrentIndex);
                }
                else
                {
                    int_MaxCount = int_MaxCount > directory.Count ? int_MaxCount : directory.Count;
                    int_CurrentIndex = directory[s_Arr[int_CurrentIndex]];
                    directory.Clear();
                }
            }

            return int_MaxCount > directory.Count ? int_MaxCount : directory.Count;
        }
    }
}