using Algorithms.Search;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Linq;

namespace Algorithms.Tests.Search
{
    public class Tests
    {
        [Test]
        public static void FindIndex_ItemPresent_IndexCorrect([Random(1, 1000, 100)] int arraySize)
        {
            // Arrange
            BinarySearcher<int> searcher = new BinarySearcher<int>();
            Randomizer random = Randomizer.CreateRandomizer();
            int[] array = Enumerable.Range(0, arraySize)
                .Select(x => random.Next(0, 1000))
                .OrderBy(x => x).ToArray();
            int expectedIndex = random.Next(0, arraySize);

            // Act
            int actualIndex = searcher.FindIndex(array, array[expectedIndex]);

            // Assert
            Assert.AreEqual(array[expectedIndex], array[actualIndex]);
        }

        [Test]
        public static void FindIndex_ItemMissing_ReturnsMinusOne(
            [Random(0, 1000, 10)] int arraySize,
            [Random(-100, 1100, 10)] int missingItem)
        {
            // Arrange
            var searcher = new BinarySearcher<int>();
            var random = Randomizer.CreateRandomizer();
            var array = Enumerable.Range(0, arraySize)
                .Select(x => random.Next(0, 1000))
                .Where(x => x != missingItem)
                .OrderBy(x => x).ToArray();

            // Act
            var actualIndex = searcher.FindIndex(array, missingItem);

            // Assert
            Assert.AreEqual(-1, actualIndex);
        }

        [Test]
        public static void FindIndex_EmptyArray_ReturnsMinusOne([Random(100, Distinct = true)] int itemToSearch)
        {
            // Arrange
            var searcher = new BinarySearcher<int>();
            var array = new int[0];

            // Act
            var actualIndex = searcher.FindIndex(array, itemToSearch);

            // Assert
            Assert.AreEqual(-1, actualIndex);
        }

    }
}