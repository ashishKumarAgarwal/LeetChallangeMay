using LeetChallengeMay.May9PerfectSquare;
using NUnit.Framework;

namespace LeetChallengeMayTest.May9PerfectSquareTest
{
    public class PerfectSquareTestTest
    {
        [Test]
        public void IsPerfectSquare_Test()
        {
            //Arrange
            PerfectSquareSolution solution = new PerfectSquareSolution();

            //Act

            var result1 = solution.IsPerfectSquare(16);
            var result2 = solution.IsPerfectSquare(14);

            //Assert
            Assert.AreEqual(true, result1);
            Assert.AreEqual(false, result2);
        }
    }
}