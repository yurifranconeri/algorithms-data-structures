using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearch;
namespace BinarySearchTest
{
    [TestClass]
    public class BinarySearchTest
    {
        [TestMethod]
        public void FindValueOnRight()
        {
            int valueToFind = 26;
            int indexToReturn = 4;
            int[] values = { 1, 3, 7, 19, 26, 32 };

            Assert.AreEqual(BinarySearch.BinarySearch.Search(values, valueToFind), indexToReturn);
        }

        [TestMethod]
        public void FindValueOnLeft()
        {
            int valueToFind = 26;
            int indexToReturn = 1;
            int[] values = { 21, 26, 32, 64, 118, 999, 1014 };

            Assert.AreEqual(BinarySearch.BinarySearch.Search(values, valueToFind), indexToReturn);
        }

        [TestMethod]
        public void NotFindValue()
        {
            int valueToFind = 8;
            int indexToReturn = -1;
            int[] values = { 1, 3, 7, 19, 26, 32 };

            Assert.AreEqual(BinarySearch.BinarySearch.Search(values, valueToFind), indexToReturn);
        }

        [TestMethod]
        public void FindValueOnOneNumberArray()
        {
            int valueToFind = 1;
            int indexToReturn = 0;
            int[] values = { 1 };

            Assert.AreEqual(BinarySearch.BinarySearch.Search(values, valueToFind), indexToReturn);
        }

        [TestMethod]
        public void FindValueOnTwoNumbersArray()
        {
            int valueToFind = 1;
            int indexToReturn = 1;
            int[] values = { 0, 1 };

            Assert.AreEqual(BinarySearch.BinarySearch.Search(values, valueToFind), indexToReturn);
        }

        [TestMethod]
        public void NotFindNullArray()
        {
            int valueToFind = 1;            
            int[] values = null;
            int valueToReturn = -1;
            Assert.AreEqual(BinarySearch.BinarySearch.Search(values, valueToFind),valueToReturn);
        }

        [TestMethod]
        public void NotFindEmptyArray()
        {
            int valueToFind = 1;
            int[] values = { };
            int valueToReturn = -1;
            Assert.AreEqual(BinarySearch.BinarySearch.Search(values, valueToFind), valueToReturn);
        }
    }
}
