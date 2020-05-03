using System.Collections.Generic;

namespace LeetChallengeMay.May3RansomNote
{
    public class RamsonNoteSolution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> magazineLetterMapping = new Dictionary<char, int>();
            foreach (var letter in magazine)
            {
                if (magazineLetterMapping.ContainsKey(letter))
                {
                    magazineLetterMapping[letter] = magazineLetterMapping[letter] + 1;
                }
                else
                {
                    magazineLetterMapping.Add(letter, 1);
                }
            }

            foreach (var letter in ransomNote)
            {
                if (magazineLetterMapping.ContainsKey(letter))
                {
                    if (magazineLetterMapping[letter] > 0)
                        magazineLetterMapping[letter] = magazineLetterMapping[letter] - 1;
                    else
                        return false;
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