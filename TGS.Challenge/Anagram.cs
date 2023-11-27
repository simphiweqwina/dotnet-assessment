using System;
using System.Linq;

namespace TGS.Challenge
{
  /*
        Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
        one another return true, else return false

        "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
        phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be rearranged into carthorse.

        areAnagrams("horse", "shore") should return true
        areAnagrams("horse", "short") should return false

        NOTE: Punctuation, including spaces should be ignored, e.g.

        horse!! shore = true
        horse  !! shore = true
          horse? heroes = true

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class Anagram
    {
      public bool AreAnagrams(string word1, string word2)
      {
            // check actual values exist
            if (word1 == null || word2 == null) { throw new ArgumentNullException(); }

            //check if the words are not the same word
            if (word1 == word2) { return false; }

            //check if the words have the same length
            if(word1.Length != word2.Length) { return false; }

            // check if words are anagrams
            char[] word1Array = word1.ToCharArray();
            char[] word2Array = word2.ToCharArray();

            for (int i = 0; i < word1Array.Length ; i++)
            {
                if (!word2Array.Contains(word1Array[i])) { return false; }
            }

            return true;
      }
    }
}
