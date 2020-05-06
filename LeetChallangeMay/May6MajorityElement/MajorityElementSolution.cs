using System.Collections.Generic;
using System.Linq;

namespace LeetChallengeMay.May6MajorityElement
{
    public class MajorityElementSolution
    {
        public int MajorityElement(int[] nums)
        {
            var argumentLength = nums.Length;
            Dictionary<int,int> mappDictionary=new Dictionary<int, int>();
            for (int index = 0; index < argumentLength; index++)
            {
                if (mappDictionary.ContainsKey(nums[index]))
                {
                    mappDictionary[nums[index]] += 1;
                }
                else
                {
                    mappDictionary.Add(nums[index],1);
                }
            }

            var maximumOccurrenceItem = mappDictionary.OrderByDescending(item => item.Value).FirstOrDefault();
            return(maximumOccurrenceItem.Value> (argumentLength / 2) )? maximumOccurrenceItem.Key : 0;
        }
    }
}
