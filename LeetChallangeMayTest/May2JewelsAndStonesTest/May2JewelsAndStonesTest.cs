using LeetChallengeMay.May2JewelsAndStones;
using NUnit.Framework;

namespace LeetChallengeMayTest.May2JewelsAndStonesTest
{
    public class May2JewelsAndStonesTest
    {
        [Test]
        public void NumJewelsInStones_Should_Return_Correct_numberOfJewels()
        {
            //Arrange
            JewelsAndStonesSolution solution = new JewelsAndStonesSolution();
            var J = "aA";
            var S = "aAAbbbb";
            var J1 = "z";
            var S1 = "ZZ";
            //Act
            var numberOfJewels = solution.NumJewelsInStones(J, S);
            var numberOfJewels1 = solution.NumJewelsInStones(J1, S1);
            //Assert
            Assert.AreEqual(numberOfJewels, 3);
            Assert.AreEqual(numberOfJewels1, 0);
        }
    }
}