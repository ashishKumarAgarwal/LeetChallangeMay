using System.Collections.Generic;
using System.Linq;

namespace LeetChallengeMay.May12SingleElementInASortedArray
{
    public class SingleElementInASortedArraySolution
    {
        public int SingleNonDuplicate(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            Dictionary<int, int> numberCountMapping = new Dictionary<int, int>();
            for (int index = 0; index < nums.Length; index++)
            {
                if (numberCountMapping.ContainsKey(nums[index]))
                {
                    numberCountMapping[nums[index]]++;
                }
                else
                {
                    numberCountMapping.Add(nums[index], 1);
                }
            }

            return numberCountMapping.FirstOrDefault(mapping => mapping.Value == 1).Key;
        }
    }
}