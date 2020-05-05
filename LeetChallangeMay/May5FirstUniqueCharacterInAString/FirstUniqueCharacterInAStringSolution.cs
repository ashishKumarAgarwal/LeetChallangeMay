using System.Collections.Generic;
using System.Linq;

namespace LeetChallengeMay.May5FirstUniqueCharacterInAString
{
    public class FirstUniqueCharacterInAStringSolution
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> charCountMapping = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (charCountMapping.ContainsKey(c))
                {
                    charCountMapping[c] += 1;
                }
                else
                {
                    charCountMapping.Add(c, 1);
                }
            }

            var uniqueChar = charCountMapping.FirstOrDefault(c => c.Value == 1).Key;

            return s.IndexOf(uniqueChar);
        }
    }
}