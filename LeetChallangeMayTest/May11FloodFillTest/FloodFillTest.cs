using LeetChallengeMay.May11FloodFill;
using NUnit.Framework;

namespace LeetChallengeMayTest.May11FloodFillTest
{
    public class FloodFillTest
    {
        [Test]
        public void FindJudge_Test()
        {
            //Arrange
            FloodFillSolution solution = new FloodFillSolution();

            var image1 = new int[][]
            {
                new int[]{1,1,1},
                new int[]{1,1,0},
                new int[]{1,0,1}
            }; 
            var image2 = new int[][]
            {
                new int[]{0,0,0},
                new int[]{0,0,0},
                new int[]{0,0,0}
            };

         
            var output1 = new int[][]
            {
                new int[]{2,2,2},
                new int[]{2,2,0},
                new int[]{2,0,1}
            };
            var output2 = new int[][]
            {
                new int[]{2,2,2},
                new int[]{2,2,2},
                new int[]{2,2,2}
            };

            //Act
            var result1 = solution.FloodFill(image1, 1, 1, 2);
            var result2 = solution.FloodFill(image2, 0, 0, 2);

            //Assert
           Assert.AreEqual(output1, result1);
            Assert.AreEqual(output2, result2);
        }
    }
}