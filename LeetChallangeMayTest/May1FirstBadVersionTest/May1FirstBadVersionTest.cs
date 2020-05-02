using LeetChallengeMay.May1FirstBadVersion;
using NUnit.Framework;

namespace LeetChallengeMayTest.May1FirstBadVersionTest
{
    public class May1FirstBadVersionTest
    {
        [Test]
        public void FirstBadVersion_Should_Return_FirstBadVersion()
        {
            //Arrange
            Solution solution = new Solution();
            //Act
            var firstBadVersion = solution.FirstBadVersion(10);
            //Assert
            Assert.AreEqual(firstBadVersion, 7);
        }
    }
}