using LeetChallengeMay.May5FirstUniqueCharacterInAString;
using LeetChallengeMay.May6MajorityElement;
using NUnit.Framework;

namespace LeetChallengeMayTest.May6MajorityElementTest
{
    public class MajorityElementTest
    {
        [Test]
        public void FindComplement_Test()
        {
            //Arrange
            MajorityElementSolution solution = new MajorityElementSolution();
            //Act
            var result1 = solution.MajorityElement(new int[]{3, 2, 3});
            var result2 = solution.MajorityElement(new int[]{2, 2, 1, 1, 1, 2, 2});

            //Assert
            Assert.AreEqual(3, result1);
            Assert.AreEqual(2, result2);
        }
    }
}