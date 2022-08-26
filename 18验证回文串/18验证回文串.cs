using System;

namespace _18验证回文串
{
    class _18验证回文串
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IsPalindrome_1("ab2a");
        }

        //双指针法
        public static bool IsPalindrome_1(string s)
        {
            int length = s.Length;
            if (length<2)
            {
                return true;
            }

            char[] f = s.ToCharArray();
            int l = 0, r = f.Length - 1;

            int length_ = 0;

            while (l<r)
            {
                bool l_IsCondition = false;
                bool r_IsCondition = false;

                string l_Str = f[l].ToString();
                string r_Str = f[r].ToString();

                if (l_Str != " " && Char.IsLetter(f[l]) || int.TryParse(l_Str,out int a))
                {
                    l_IsCondition = true;
                    l_Str = l_Str.ToLower();
                }   
                else
                {
                    l++;
                }
                if (r_Str != " " && Char.IsLetter(f[r]) || int.TryParse(r_Str, out int b))
                {
                    r_IsCondition = true;
                    r_Str = r_Str.ToLower();
                }
                else
                {
                    r--;
                }

                if (l_IsCondition&& r_IsCondition)
                {
                    l++;
                    r--;
                    if (l_Str!=r_Str)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}