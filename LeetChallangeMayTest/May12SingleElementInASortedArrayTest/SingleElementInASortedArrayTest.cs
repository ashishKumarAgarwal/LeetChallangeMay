using LeetChallengeMay.May12SingleElementInASortedArray;
using NUnit.Framework;

namespace LeetChallengeMayTest.May12SingleElementInASortedArrayTest
{
    public class SingleElementInASortedArrayTest
    {
        [Test]
        public void FindJudge_Test()
        {
            //Arrange
            SingleElementInASortedArraySolution solution = new SingleElementInASortedArraySolution();

            int[] nums1 = new int[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 };
            int[] nums2 = new int[] { 3, 3, 7, 7, 10, 11, 11 };
            //Act
            var result1 = solution.SingleNonDuplicate(nums1);
            var result2 = solution.SingleNonDuplicate(nums2);

            //Assert
            Assert.AreEqual(2, result1);
            Assert.AreEqual(10, result2);
        }
    }
}