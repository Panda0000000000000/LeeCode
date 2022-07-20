using System;

namespace 最长回文子串
{
    class 最长回文子串
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string resault = LongestPalindrome_2("babad");

            Console.ReadKey();
        }

        //暴力求解
        public static string LongestPalindrome_1(string s)
        {
            int len = s.Length;
            if (len<2)
            {
                return s;
            }

            char[] charArr= s.ToCharArray();

            int maxLen = 1;
            int begin = 0;  
            for(int i = 0; i < charArr.Length-1; i++)
            {
                for(int j = i+1; j < charArr.Length; j++)
                {
                    if(j-i+1>maxLen && Judge_IsStrBack(charArr,i,j))
                    {
                        begin = i;
                        maxLen = (j - i)+1;
                    }
                }
            }

            return s.Substring(begin, maxLen);

            bool Judge_IsStrBack(char[] charArr,int begin,int end)
            {
                while (begin<end)
                {
                    if (charArr[begin] == charArr[end])
                    {
                        begin++;
                        end--;

                    }
                    else
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        //动态规划
        public static string LongestPalindrome_2(string s)
        {
            int len = s.Length;
            if (len<2)
            {
                return s;
            }

            int maxLen = 1;
            int begin = 0;

            bool[,] dp = new bool[len,len];
            for(int i = 0; i < len; i++)
            {
                dp[i, i] = true;
            }

            char[] charArr = s.ToCharArray();

            for (int j = 1; j < len; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    if (charArr[i] != charArr[j])
                    {
                        dp[i, j] = false;
                    }
                    else
                    {
                        if (j - i < 3)
                        {
                            dp[i, j] = true;
                        }
                        else
                        {
                            dp[i, j] = dp[i + 1, j - 1];
                        }
                    }

                    if (j-i+1>maxLen && dp[i,j])
                    {
                        maxLen = j - i + 1;
                        begin = i;
                    }
                }
            }

            return s.Substring(begin, maxLen);
        }

        public static string LongestPalindrome(string s)
        {
            if (true)
            {
                return "";
            }
            int len = s.Length;
            if (len<2)
            {
                return s;
            }

            int maxLen = 1;
            int begin = 0;

            bool[,] cacheState = new bool[len,len];
            for (int i = 0; i < len; i++)
            {
                cacheState[i,i] = true;
            }

            char[] charArray = s.ToCharArray();

            for (int L = 2; L < len; L++)
            {
                for (int i = 0; i < len; i++)
                {
                    int j = L + i - 1;
                    if (j>=len)
                    {
                        break;
                    }
                    if (charArray[i] != charArray[j])
                    {
                        cacheState[i, j] = false;
                    }
                    else
                    {
                        if (j - i < 3)
                        {
                            cacheState[i, j] = true;
                        }
                        else
                        {
                            cacheState[i, j] = cacheState[i + 1, j - 1];
                        }
                    }

                    if (cacheState[i,j] && j-i+1>maxLen)
                    {
                        maxLen = j - i + 1;
                    }
                }
            }
        }
    }
}