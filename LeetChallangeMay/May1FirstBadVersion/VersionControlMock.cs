using System;
using System.Collections.Generic;
using System.Text;

namespace LeetChallengeMay.May1FirstBadVersion
{
    public class VersionControlMock
    {
        private static Dictionary<int, bool> VersionStatus = new Dictionary<int, bool>()
        {
            //True - good version
            //False - bad version

            {1,false },
            {2,false },
            {3,false },
            {4,false },
            {5,false },
            {6,false },
            {7,true },
            {8,true },
            {9,true },
            {10,true },
        };

        protected bool IsBadVersion(int versionNumber)
        {
            return VersionStatus[versionNumber];
        }
    }
}
