using FluentAssertions;
using LeetChallengeMay.May22SortCharactersByFrequency;
using NUnit.Framework;

namespace LeetChallengeMayTest.May17Anagrams
{
    public class SortCharactersByFrequencyTestAnagramsTest
    {
        [Test]
        public void FrequencySort_Test()
        {
            //Arrange

            SortCharactersByFrequencySolution solution = new SortCharactersByFrequencySolution();
            //Act
            var result1 = solution.FrequencySort("tree");
            var result2 = solution.FrequencySort("cccaaa");
            var result3 = solution.FrequencySort("Aabb");

            //assert
            result1.Should().BeOneOf("eert","eetr");
            result2.Should().Be("cccaaa","aaaccc");
            result3.Should().Be("bbAa","bbaA");
        }
    }
}