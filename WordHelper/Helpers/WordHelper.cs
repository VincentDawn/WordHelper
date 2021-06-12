using System;
using System.Linq;
using System.Text.RegularExpressions;
using WordHelper.Interfaces;

namespace WordHelper.Helpers
{
    public class WordHelper : IWordHelper
    {
        public bool IsAnagram(string word1, string word2)
        {
            word1 = PrepareString(word1);
            word2 = PrepareString(word2);

            return String.Concat(word1.OrderBy(x => x)) == String.Concat(word2.OrderBy(x => x));
        }

        public bool IsPalindrome(string word)
        {
            return PrepareString(word) == String.Concat(PrepareString(word).Reverse());
        }

        private string PrepareString(string word)
        {
            Regex regex = new Regex(@"[^a-zA-Z]");
            return regex.Replace(word, "").ToLower();
        }
    }
}
