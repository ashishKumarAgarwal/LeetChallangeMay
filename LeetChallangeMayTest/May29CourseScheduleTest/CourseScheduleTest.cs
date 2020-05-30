using FluentAssertions;
using LeetChallengeMay.May29CourseSchedule;
using NUnit.Framework;

namespace LeetChallengeMayTest.May29CourseScheduleTest
{
    public class CourseScheduleTest
    {
        [Test]
        public void CanFinish_Test()
        {
            //Arrange

            CourseScheduleSolution solution = new CourseScheduleSolution();
            //Act
            var result1 = solution.CanFinish(2, new int[][] { new int[] { 1, 0 } });
            var result2 = solution.CanFinish(2, new int[][] { new int[] { 1, 0 }, new int[] { 0, 1 } });

            //assert
            result1.Should().BeTrue();
            result2.Should().BeFalse();
        }
    }
}