using LeetChallengeMay.May1FirstBadVersion;

namespace LeetChallengeMay.May1FirstBadVersion
{
   public class Solution : VersionControlMock
    {
        public int FirstBadVersion(int n)
        {
            var leftValue = 1;
            var rightValue = n;
            while (leftValue != rightValue)
            {
                var mid = leftValue + (rightValue - leftValue) / 2;
                if (IsBadVersion(mid))
                    rightValue = mid;
                else
                    leftValue = mid+1;
            }

            return leftValue;


        }

        
    }
}
