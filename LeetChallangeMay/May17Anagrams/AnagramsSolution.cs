using System;
using System.Collections.Generic;

namespace LeetChallengeMay.May17Anagrams
{
    public class AnagramSolution
    {
        public IList<int> FindAnagrams(String s, String p)
        {
            int[] alphabetCount = new int[26];
            int sLength = s.Length, pLength = p.Length;

            if (pLength > sLength) 
                return new List<int>();

            for (int i = 0; i < pLength; i++)
            {
                alphabetCount[s[i] - 'a']++;
                alphabetCount[p[i] - 'a']--;
            }

            List<int> anagramStartIndexes = new List<int>();

            for (int i = pLength; i < sLength; i++)
            {
                if (IsAnagram(alphabetCount))
                {
                    anagramStartIndexes.Add(i - pLength);
                }
                alphabetCount[s[i] - 'a']++;
                alphabetCount[s[(i - pLength)] - 'a']--;
            }
            if (IsAnagram(alphabetCount))
            {
                anagramStartIndexes.Add(sLength - pLength);
            }

            return anagramStartIndexes;
        }

        bool IsAnagram(int[] alphabetCount)
        {
            for (int i = 0; i < alphabetCount.Length; i++)
            {
                if (alphabetCount[i] != 0) return false;
            }
            return true;
        }
    }
}