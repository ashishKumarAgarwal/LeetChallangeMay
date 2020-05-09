using LeetChallengeMay.May8CheckIfInStraightLine;
using NUnit.Framework;

namespace LeetChallengeMayTest.May8CheckIfInStraightLineTest
{
    public class CheckIfInStraightLineTest
    {
        [Test]
        public void IsCousins_Test()
        {
            //Arrange
            CheckIfInStraightLineSolution solution = new CheckIfInStraightLineSolution();

            //Act

            var result1 = solution.CheckStraightLine(new int[][]
            {
                new int[] { 1, 1 }, new int[] { 2, 2 }, new int[] { 3, 4 },
                new int[] { 4, 5 },new int[] { 5, 6 },new int[] { 7, 7 }
            });

            var result2 = solution.CheckStraightLine(new int[][]
            {
                new int[] { 1, 2}, new int[] { 2, 3 }, new int[] { 3, 4 },
                new int[] { 4, 5 },new int[] { 5, 6 },new int[] { 6, 7 }
            });

            //Assert
            Assert.AreEqual(false, result1);
            Assert.AreEqual(true, result2);
        }
    }
}