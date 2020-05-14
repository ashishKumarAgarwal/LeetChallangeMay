using LeetChallengeMay.May13RemoveKDigits;
using NUnit.Framework;

namespace LeetChallengeMayTest.May13RemoveKDigits
{
    public class RemoveKDigitsTest
    {
        [Test]
        public void RemoveKdigits_Test()
        {
            //Arrange
            RemoveKDigitsSolution solution = new RemoveKDigitsSolution();

            //Act
            var result1 = solution.RemoveKdigits("1432219", 3);
            var result2 = solution.RemoveKdigits("10200", 1);
            var result3 = solution.RemoveKdigits("10", 2);

            //Assert
            Assert.AreEqual("1219", result1);
            Assert.AreEqual("200", result2);
            Assert.AreEqual("0", result3);
        }
    }
}