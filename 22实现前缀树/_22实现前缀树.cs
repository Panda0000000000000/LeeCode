using System;
using System.Collections.Generic;

namespace _22实现前缀树
{
    class _22实现前缀树
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Trie
    {
        Trie[] children;
        bool is_End;
        public Trie()
        {
            children = new Trie[26];
            is_End = false;
        }

        public void Insert(string word)
        {
            Trie node = this;
            char[] chars = word.ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                char ch = chars[i];
                int index = ch - 'a';
                if (node.children[index]==null)
                {
                    node.children[index] = new Trie();
                }

                node = node.children[index];
            }

            node.is_End = true;
        }

        public bool Search(string word)
        {
            Trie node = SearchPrefix(word);
            return node != null && node.is_End;
        }

        public bool StartsWith(string prefix)
        {
            return SearchPrefix(prefix) != null;
        }

        Trie SearchPrefix(string prefix)
        {
            HashSet<char> char_Hash = new HashSet<char>(prefix.ToCharArray());
            char[] chars = prefix.ToCharArray();
            Trie node = this;
            for (int i = 0; i < prefix.Length; i++)
            {
                char ch = chars[i];
                int index = ch - 'a';
                if (node.children[index]==null)
                {
                    return null;
                }

                node = node.children[index];
            }

            return node;
        }
    }
}