using LeetChallengeMay.May3RansomNote;
using NUnit.Framework;

namespace LeetChallengeMayTest.May2JewelsAndStonesTest
{
    public class May3RansomNoteTest
    {
        [Test]
        public void CanConstruct_Test()
        {
            //Arrange
            RamsonNoteSolution solution = new RamsonNoteSolution();
            //Act
            var result1 = solution.CanConstruct("a", "b");
            var result2 = solution.CanConstruct("aa", "ab");
            var result3 = solution.CanConstruct("aa", "aab");
            var result4 = solution.CanConstruct("aabcc", "aab");
            var result5 = solution.CanConstruct("", "aab");
            var result6 = solution.CanConstruct("", "");
            //Assert
            Assert.IsFalse(result1);
            Assert.IsFalse(result2);
            Assert.IsTrue(result3);
            Assert.IsFalse(result4);
            Assert.IsTrue(result5);
            Assert.IsTrue(result6);
        }
    }
}