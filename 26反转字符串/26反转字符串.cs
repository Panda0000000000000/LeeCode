using System;

namespace _26反转字符串
{
    class _26反转字符串
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ReverseString(new char[] {'h','e','l','l','o'});
        }

        //for循环
        public static void ReverseString(char[] s)
        {
            char cache;
            int length = s.Length-1;
            for (int i = 0; i < s.Length/2; i++)
            {
                cache = s[i];
                s[i] = s[length - i];
                s[length - i] = cache;
            }
        }

        //while循环
        public static void ReverseString_2(char[] s)
        {
            int let = 0;
            int right = s.Length - 1;
            while (let<right)
            {
                Swap(s,let++, right--);
            }

            void Swap(char[] s, int left, int right)
            {
                //第一种
                s[left] =((char)(s[left] + s[right]));
                s[right] = (char)(s[left] - s[right]);
                s[left] = (char)(s[left] - s[right]);

                //第二种

                s[left] = (char)(s[left] ^ s[right]);
                s[right] = (char)(s[left] ^ s[right]);
                s[left] = (char)(s[left] ^ s[right]);

            }
        }
    }
}