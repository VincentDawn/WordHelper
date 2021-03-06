using System.Collections.Generic;
using WordHelper.Interfaces;

namespace WordHelper.Helpers
{
    public class FormalLogicWordHelper : BaseWordHelper, IWordHelper
    {
        new public bool IsAnagram(string word1, string word2)
        {
            word1 = PrepareString(word1);
            word2 = PrepareString(word2);

            // Set compare
            HashSet<char> set1 = new HashSet<char>(word1.ToCharArray());
            HashSet<char> set2 = new HashSet<char>(word2.ToCharArray());

            return set1.SetEquals(set2);
        }
    }
}
