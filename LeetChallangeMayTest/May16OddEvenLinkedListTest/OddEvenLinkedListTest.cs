using FluentAssertions;
using LeetChallengeMay.May16OddEvenLinkedList;
using NUnit.Framework;

namespace LeetChallengeMayTest.May16OddEvenLinkedListTest
{
    public class OddEvenLinkedListTest
    {
        [Test]
        public void OddEvenList_Test()
        {
            //Arrange
            ListNode inputNodeList = new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 2,
                    next = new ListNode()
                    {
                        val = 3,
                        next = new ListNode()
                        {
                            val = 4,
                            next = new ListNode()
                            {
                                val = 5,
                                next = null
                            }
                        }
                    }
                }
            };

            ListNode outputNodeList = new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 3,
                    next = new ListNode()
                    {
                        val = 5,
                        next = new ListNode()
                        {
                            val = 2,
                            next = new ListNode()
                            {
                                val = 4,
                                next = null
                            }
                        }
                    }
                }
            };

            //Act
            OddEvenLinkedListSolution solution = new OddEvenLinkedListSolution();
            var result = solution.OddEvenList(inputNodeList);

            //assert
            outputNodeList.Should().BeEquivalentTo(result);
        }
    }
}