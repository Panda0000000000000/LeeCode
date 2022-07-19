using System;

namespace 最长回文子串
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LongestPalindrome_1("cbbd");

            Console.ReadKey();
        }

        //暴力求解
        public static string LongestPalindrome_1(string s)
        {
            int len = s.Length;
            if (len<=2)
            {
                return s;
            }

            char[] charArr= s.ToCharArray();

            int maxLen = 0;
            int begin = 0;
            for (int i = 0; i < charArr.Length-2; i++)
            {
                for (int j = 0; j < charArr.Length; j++)
                {
                    if (j-i>maxLen && Judge_IsStrBack(charArr,i,j))
                    {
                        begin = i;
                        maxLen = j + 1;
                    }
                }
            }

            return s.Substring(begin, maxLen);

            bool Judge_IsStrBack(char[] charArr,int begin,int end)
            {
                while (begin!=end)
                {
                    if ((end-begin) >1 && charArr[begin] == charArr[end])
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