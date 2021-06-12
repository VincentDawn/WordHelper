using System.Collections.Generic;
using WordHelper.Interfaces;

namespace WordHelper.Helpers
{
    public class MapWordHelper : BaseWordHelper, IWordHelper
    {
        new public bool IsAnagram(string word1, string word2)
        {
            word1 = PrepareString(word1);
            word2 = PrepareString(word2);

            // I could check length in all the other implementations but only going to include it here
            if (word1.Length != word2.Length)
            {
                return false;
            }

            // Add to buckets
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            foreach (var c in word1)
            {
                int count = dictionary.GetValueOrDefault(c, -1);
                if (count >= 0)
                {
                    dictionary[c] = ++count;
                }
                else
                {
                    dictionary.Add(c, 1);
                }
            }

            // Remove from buckets
            foreach (var c in word2)
            {
                int count = dictionary.GetValueOrDefault(c, 0);
                if (count > 0)
                {
                    dictionary[c] = --count;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
