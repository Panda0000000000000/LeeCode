namespace _71同构字符串
{
    internal class _71同构字符串
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length!=t.Length)
            {
                return false;
            }

            char[] s_Chars = s.ToCharArray();
            char[] t_Chars = t.ToCharArray();
            Dictionary<int, int> cache_S = new Dictionary<int, int>();
            Dictionary<int, int> cache_T = new Dictionary<int, int>();

            for (int i = 0; i < s.Length; i++)
            {
                int c = s_Chars[i] - 'a';
                int b = t_Chars[i] - 'a';
                if (!cache_S.ContainsKey(c))
                {
                    cache_S.Add(c, b);
                }
                if (!cache_T.ContainsKey(b))
                {
                    cache_T.Add(b, c);
                }

                if (cache_S[c] != b || cache_T[b]!=c)
                {
                    return false;
                }
            }

            return true;
        }
    }
}