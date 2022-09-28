using System;
using System.Collections.Generic;

namespace _23单词搜索2
{
    class _23单词搜索2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static IList<string> FindWords(char[][] board, string[] words)
        {
            int[][] dirs = new int[][]
                {
                    new int[]{ 1,0},
                    new int[]{ -1,0},
                    new int[]{ 0,1},
                    new int[]{ 0,-1},
                };

            Trie trie = new Trie();
            foreach (string word in words)
            {
                trie.Insert(word);
            }


            void DFS(char[][] board, Trie now, int i1, int j1, ISet<string> ans)
            {
                if (!now.children.ContainsKey(board[i1][j1]))
                {
                    return;
                }

                char ch = board[i1][j1];
                now = now.children[ch];
                if (!"".Equals(now.word))
                {
                    ans.Add(now.word);
                }

                board[i1][j1] = '#';
                foreach (int[] dir in dirs)
                {
                    int i2 = i1 + dir[0], j2 = j1 + dir[1];
                    if (i2>=0&&i2<board.Length)
                    {

                    }
                }
            }
        }

        class Trie
        {
            public string word;
            public Dictionary<char, Trie> children;
            public bool isWord;
            public Trie()
            {
                this.word = "";
                this.children = new Dictionary<char, Trie>();
            }

            public void Insert(string word)
            {
                Trie cur = this;
                foreach (char c in word)
                {
                    if (!cur.children.ContainsKey(c))
                    {
                        cur.children.Add(c, new Trie());
                    }

                    cur = cur.children[c];
                }

                cur.word = word;
            }
        }
    }
}