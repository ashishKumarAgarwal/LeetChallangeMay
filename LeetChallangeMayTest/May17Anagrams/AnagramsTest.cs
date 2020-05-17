using FluentAssertions;
using LeetChallengeMay.May17Anagrams;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetChallengeMayTest.May17Anagrams
{
    public class AnagramsTest
    {
        [Test]
        public void FindAnagrams_Test()
        {
            //Arrange

            AnagramSolution anagramSolution = new AnagramSolution();
            //Act
            var result1 = anagramSolution.FindAnagrams("abab", "ab");
            var result2 = anagramSolution.FindAnagrams("baa", "aa");
            var result3 = anagramSolution.FindAnagrams("ababababab", "aab");

          

            //assert
            result1.Should().BeEquivalentTo(new List<int>()
            {
                0,1,2
            });
            result2.Should().BeEquivalentTo(new List<int>()
            {
                1
            });
            result3.Should().BeEquivalentTo(new List<int>()
            {
                0,2,4,6
            });
        }
    }
}