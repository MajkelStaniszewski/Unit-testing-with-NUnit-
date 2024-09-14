using NUnit.Framework;
using System.Collections.Generic;

namespace WordCounterApp.Tests
{
    [TestFixture]
    public class WordCounterTests
    {
        [Test]
        public void Test_CountWordOccurrences_Case1()
        {
            // Arrange
            string input = "Go do that thing that you do so well.";
            var expected = new Dictionary<string, int> { {"go", 1}, {"do", 2}, {"that", 2}, {"thing", 1}, {"you", 1}, {"so", 1}, {"well", 1} };

            // Act
            var actual = WordCounter.CountWordOccurrences(input);

            // Assert
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [Test]
        public void Test_CountWordOccurrences_Case2()
        {
            // Arrange
            string input = "Hello, hello, hello! Are you there?";
            var expected = new Dictionary<string, int> { {"hello", 3}, {"are", 1}, {"you", 1}, {"there", 1} };

            // Act
            var actual = WordCounter.CountWordOccurrences(input);

            // Assert
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [Test]
        public void Test_CountWordOccurrences_Case3()
        {
            // Arrange
            string input = "The quick brown fox jumps over the lazy dog. The dog barks.";
            var expected = new Dictionary<string, int> { {"the", 3}, {"quick", 1}, {"brown", 1}, {"fox", 1}, {"jumps", 1}, {"over", 1}, {"lazy", 1}, {"dog", 2}, {"barks", 1} };

            // Act
            var actual = WordCounter.CountWordOccurrences(input);

            // Assert
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [Test]
        public void Test_CountWordOccurrences_EmptyInput()
        {
            // Arrange
            string input = "";
            var expected = new Dictionary<string, int>();

            // Act
            var actual = WordCounter.CountWordOccurrences(input);

            // Assert
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}
