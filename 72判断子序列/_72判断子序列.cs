namespace _72判断子序列
{
    internal class _72判断子序列
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            IsSubsequence_1("abc", "dddddabc");
        }

        //双指针
        public static bool IsSubsequence_1(string s, string t)
        {
            int s_Index = 0;
            int t_Index = 0;
            char[] t_Chars = t.ToCharArray();
            char[] s_Chars = s.ToCharArray();
            while (t_Index < t.Length && s_Index < s.Length)
            {
                if (t_Chars[t_Index] == s_Chars[s_Index])
                {
                    s_Index++;
                    t_Index++;
                }
                else
                {
                    t_Index++;
                }
            }

            return s_Index == s.Length;
        }

        //动态规划
        public static bool IsSubsequence_1(string s, string t)
        {

        }
    }
}