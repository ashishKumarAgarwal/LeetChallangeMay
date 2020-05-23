using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetChallengeMay.May22SortCharactersByFrequency
{
    public class SortCharactersByFrequencySolution
    {
        public string FrequencySort(string s)
        {
            Dictionary<char, int> mapping = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (mapping.ContainsKey(c))
                {
                    mapping[c]++;
                }
                else
                {
                    mapping.Add(c, 1);
                }
            }

            var orderedMapping = mapping.OrderByDescending(pair => pair.Value);

            StringBuilder sb = new StringBuilder();

            foreach (var keyValuePair in orderedMapping)
            {
                for (int i = 0; i < keyValuePair.Value; i++)
                {
                    sb.Append(keyValuePair.Key);
                }
            }
            return sb.ToString();
        }
    }
}