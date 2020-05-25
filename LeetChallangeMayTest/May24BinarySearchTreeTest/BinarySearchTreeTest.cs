using FluentAssertions;
using LeetChallengeMay.May25UncrossedLines;
using NUnit.Framework;

namespace LeetChallengeMayTest.May25UncrossedLines
{
    public class BinarySearchTreeTest
    {
        [Test]
        public void BstFromPreorder_Test()
        {
            //Arrange

            BinarySearchTreeSolution solution = new BinarySearchTreeSolution();
            var expectedOutput = new TreeNode
            {
                val = 8,
                left = new TreeNode
                {
                    val = 5,
                    left = new TreeNode
                    {
                        val = 1
                    },
                    right = new TreeNode
                    {
                        val = 7
                    }
                },
                right=new TreeNode
                {
                    val=10,
                    right=new TreeNode
                    {
                        val=12
                    }
                }
            };
            //Act
            var result1 = solution.BstFromPreorder(new int[] { 8, 5, 1, 7, 10, 12 });


            //assert
             result1.Should().BeEquivalentTo(expectedOutput);

        }
    }
}