using FluentAssertions;
using LeetChallengeMay.May25UncrossedLines;
using NUnit.Framework;

namespace LeetChallengeMayTest.May25UncrossedLines
{
    public class UncrossedLinesTest
    {
        [Test]
        public void MaxUncrossedLines_Test()
        {
            //Arrange

            UncrossedLinesSolution solution = new UncrossedLinesSolution();
            //Act
            int result1 = solution.MaxUncrossedLines(new int[] { 1, 4, 2 }, new int[] { 1, 2, 4 });
            int result2 = solution.MaxUncrossedLines(new int[] { 2, 5, 1, 2, 5 }, new int[] { 10, 5, 2, 1, 5, 2 });
            int result3 = solution.MaxUncrossedLines(new int[] { 1, 3, 7, 1, 7, 5 }, new int[] { 1, 9, 2, 5, 1 });
            int result4 = solution.MaxUncrossedLines(new int[] { 1, 1, 2, 1, 2 }, new int[] { 1, 3, 2, 3, 1 });

            //assert
            result1.Should().Be(2);
            result2.Should().Be(3);
            result3.Should().Be(2);
            result4.Should().Be(3);
        }
    }
}