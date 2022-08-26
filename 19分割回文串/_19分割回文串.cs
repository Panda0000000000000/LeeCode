using System;
using System.Collections.Generic;

namespace _19分割回文串
{
    class _19分割回文串
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public IList<IList<string>> Partition(string s)
        {
            IList<IList<string>> resault = new List<IList<string>>();

            char[] str = s.ToCharArray();
            int len = s.Length;
            bool[,] f = new bool[len,len];

            for (int i = 0; i < len; i++)
            {
                f[i, i] = true;
            }

            for (int i = len-1; i >=0; i++)
            {

            }

            void dfs(string s,int i)
            {
                if (i==)
                {

                }
            }
        }
    }
}
