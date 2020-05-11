using LeetChallengeMay.May10FindTheTownJudge;
using NUnit.Framework;

namespace LeetChallengeMayTest.May10FindTheTownJudgeTest
{
    public class FindTheTownJudgeTest
    {
        [Test]
        public void FindJudge_Test()
        {
            //Arrange
            FindTheTownJudgeSolution solution = new FindTheTownJudgeSolution();

            //Act

            var result1 = solution.FindJudge(2, new int[][]
            {
                new int[]{1,2}
            });
            var result2 = solution.FindJudge(3, new int[][]
            {
                new int[]{1,3},
                new int[]{2,3}
            });
            var result3 = solution.FindJudge(3, new int[][]
            {
                new int[]{1,3},
                new int[]{2,3},
                  new int[]{3,1}
            });
            var result4 = solution.FindJudge(3, new int[][]
            {
                new int[]{1,2},
                new int[]{2,3}
            });
            var result5 = solution.FindJudge(4, new int[][]
            {
                new int[]{1,3},
                new int[]{1,4},
                 new int[]{2,3},
                new int[]{2,4},
                new int[]{4,3}
            });

            var result6 = solution.FindJudge(1, new int[][]
         {
                new int[]{ },
               
         });

            //Assert
            Assert.AreEqual(2, result1);
            Assert.AreEqual(3, result2);
            Assert.AreEqual(-1, result3);
            Assert.AreEqual(-1, result4);
            Assert.AreEqual(3, result5);
            Assert.AreEqual(1, result6);
        }
    }
}