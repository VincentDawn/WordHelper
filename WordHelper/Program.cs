using System;
using System.Collections.Generic;
using System.Linq;
using WordHelper.Helpers;
using WordHelper.Interfaces;

namespace WordHelper
{
    class Program
    {
        static void Main()
        {
            IWordHelper baseWordHelper = new BaseWordHelper();
            IWordHelper formalLogicWordHelper = new FormalLogicWordHelper();
            IWordHelper mapWordHelper = new MapWordHelper();

            var words = new List<string>() { "Tar", "Elbow", "Anna", "Rat", "Dormitory", "Racecar", "Silent", "Silence", "Listen", "The Eyes", "God", "Nana", "They See!", "Coffee Hit?", "Old West Action", "The Office", "Clint Eastwood", "Dog" };

            Console.WriteLine("Base");
            CheckWords(baseWordHelper, words);

            Console.WriteLine("Formal");
            CheckWords(formalLogicWordHelper, words);

            Console.WriteLine("Map");
            CheckWords(mapWordHelper, words);
        }

        public static void CheckWords(IWordHelper helper, List<string> words)
        {
            // Assumption: Iterate over all words
            foreach (var word1 in words)
            {
                // Assumption: Ignore any words that are exact matches
                foreach (var word2 in words.Where(x => x != word1).ToList())
                {
                    if (helper.IsAnagram(word1, word2))
                    {
                        Console.WriteLine($"{word1} is an anagram of {word2}.");
                    }
                }

                if (helper.IsPalindrome(word1))
                {
                    Console.WriteLine($"{word1} is a palindrome.");
                }
            }
        }
    }
}
