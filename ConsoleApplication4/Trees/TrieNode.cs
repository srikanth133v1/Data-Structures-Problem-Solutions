using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class TrieNode
    {
        public TrieNode[] children = new TrieNode[26];
        public int frequency;
        public int index { get; set; }
    }
}
