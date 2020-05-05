using LeetChallengeMay.May5FirstUniqueCharacterInAString;
using NUnit.Framework;

namespace LeetChallengeMayTest.May5FirstUniqueCharacterInAStringTest
{
    public class FirstUniqueCharacterInAStringSolutionTest
    {
        [Test]
        public void FindComplement_Test()
        {
            //Arrange
            FirstUniqueCharacterInAStringSolution solution = new FirstUniqueCharacterInAStringSolution();
            //Act
            var result1 = solution.FirstUniqChar("leetcode");
            var result2 = solution.FirstUniqChar("loveleetcode");
            var result3 = solution.FirstUniqChar("abc");

            //Assert
            Assert.AreEqual(0, result1);
            Assert.AreEqual(2, result2);
            Assert.AreEqual(0, result3);
        }
    }
}