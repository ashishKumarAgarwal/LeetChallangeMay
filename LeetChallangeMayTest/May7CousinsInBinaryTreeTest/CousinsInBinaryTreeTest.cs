using LeetChallengeMay.May7CousinsInBinaryTree;
using NUnit.Framework;

namespace LeetChallengeMayTest.May7CousinsInBinaryTreeTest
{
    public class CousinsInBinaryTreeTest
    {
        [Test]
        public void IsCousins_Test()
        {
            //Arrange
            CousinsInBinaryTreeSolution solution = new CousinsInBinaryTreeSolution();

            var treeRoot1 = new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2,
                    left = new TreeNode()
                    {
                        val = 4,
                        left = null,
                        right = null
                    },
                    right = null
                }
                ,
                right = new TreeNode()
                {
                    val = 3,
                    left = null,
                    right = null
                }
            };

            var treeRoot2 = new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2,
                    right = new TreeNode()
                    {
                        val = 4,
                        left = null,
                        right = null
                    },
                    left = null
                }
                ,
                right = new TreeNode()
                {
                    val = 3,
                    left = null,
                    right = new TreeNode()
                    {
                        val = 5,
                        left = null,
                        right = null
                    }
                }
            };

            var treeRoot3 = new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2,
                    right = new TreeNode()
                    {
                        val = 4,
                        left = null,
                        right = null
                    },
                    left = null
                }
                ,
                right = new TreeNode()
                {
                    val = 3,
                    left = null,
                    right = null
                }
            };

            var treeRoot4 = new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2,
                    right = new TreeNode()
                    {
                        val = 8,
                        left = null,
                        right = null
                    },
                    left = new TreeNode()
                    {
                        val = 3,
                        left = null,
                        right = new TreeNode()
                        {
                            val = 7,
                            left = null,
                            right = null
                        }
                    }
                }
                ,
                right = new TreeNode()
                {
                    val = 4,
                    right = new TreeNode()
                    {
                        val = 5,
                        left = null,
                        right = null
                    },
                    left = new TreeNode()
                    {
                        val = 6,
                        left = null,
                        right = null
                    }
                }
            };

            var treeRoot5 = new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2,
                    right = new TreeNode()
                    {
                        val = 4,
                        left = null,
                        right = null
                    },
                    left = new TreeNode()
                    {
                        val = 3,
                        left = new TreeNode()
                        {
                            val = 5,
                            left = null,
                            right = null
                        },
                        right = null
                    }
                }
            };

            //Act

            var result1 = solution.IsCousins(treeRoot1, 4, 3);
            var result2 = solution.IsCousins(treeRoot2, 5, 4);
            var result3 = solution.IsCousins(treeRoot3, 2, 3);
            var result4 = solution.IsCousins(treeRoot4, 5, 8);
            var result5 = solution.IsCousins(treeRoot5, 2, 4);

            //Assert
            Assert.AreEqual(false, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(false, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(false, result5);
        }
    }
}