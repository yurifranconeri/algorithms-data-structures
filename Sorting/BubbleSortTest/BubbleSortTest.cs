using Microsoft.VisualStudio.TestTools.UnitTesting;
using BubbleSort;

namespace BubbleSortTest
{
    [TestClass]
    public class BubbleSortTest
    {
        [TestMethod]
        public void SortUnsortedArray()
        {
            int[] unsortedArray = { 9, 3, 5, 1, 2, 7, 6, 4, 8 };
            int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] resultArray = BubbleSort.BubbleSort.Sort(unsortedArray);

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Assert.AreEqual(sortedArray[i], resultArray[i]);
            }
        }

        [TestMethod]
        public void SortUnsortedArrayWithEqualElements()
        {
            int[] unsortedArray = { 9, 8, 3, 4, 7, 5, 8, 0, 1, 8, 6, 2 };
            int[] sortedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 8, 8, 9 };
            var resultArray = BubbleSort.BubbleSort.Sort(unsortedArray);
            for (int indexToCompare = 0; indexToCompare < unsortedArray.Length; indexToCompare++)
            {
                Assert.AreEqual(sortedArray[indexToCompare], unsortedArray[indexToCompare]);
            }
        }

        [TestMethod]
        public void SortAlreadySortedArray()
        {
            int[] unsortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] resultArray = BubbleSort.BubbleSort.Sort(unsortedArray);

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Assert.AreEqual(sortedArray[i], resultArray[i]);
            }

        }

        [TestMethod]
        public void SortSortedWithOneItemArray()
        {
            int[] unsortedArray = { 9 };
            int[] sortedArray = { 9 };
            int[] resultArray = BubbleSort.BubbleSort.Sort(unsortedArray);

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Assert.AreEqual(sortedArray[i], resultArray[i]);
            }
        }

        [TestMethod]
        public void SortUnsortedWithTwoItemsArray()
        {
            int[] unsortedArray = { 9, 1 };
            int[] sortedArray = { 1, 9 };
            int[] resultArray = BubbleSort.BubbleSort.Sort(unsortedArray);

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Assert.AreEqual(sortedArray[i], resultArray[i]);
            }
        }

        [TestMethod]
        public void SortEmptyArray()
        {
            int[] unsortedArray = { };
            int[] resultArray = BubbleSort.BubbleSort.Sort(unsortedArray);

            Assert.AreEqual(unsortedArray, resultArray);
        }

        [TestMethod]
        public void SortNullArray()
        {
            int[] unsortedArray = null;
            int[] sortedArray = null;
            int[] resultArray = BubbleSort.BubbleSort.Sort(unsortedArray);

            Assert.AreEqual(sortedArray, resultArray);
        }
    }
}
