using LeetChallengeMay.May4NumberComplement;
using NUnit.Framework;

namespace LeetChallengeMayTest.May4NumberComplementTest
{
    public class NumberComplementSolutionTest
    {
        [Test]
        public void FindComplement_Test()
        {
            //Arrange
            NumberComplementSolution solution = new NumberComplementSolution();
            //Act
            var result1 = solution.FindComplement(5);
            var result2 = solution.FindComplement(1);

            //Assert
            Assert.AreEqual(2, result1);
            Assert.AreEqual(0, result2);
        }
    }
}