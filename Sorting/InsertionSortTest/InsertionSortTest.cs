using Microsoft.VisualStudio.TestTools.UnitTesting;
using InsertionSort;

namespace InsertionSortTest
{
    [TestClass]
    public class InsertionSortTest
    {
        [TestMethod]
        public void SortUnsortedArray()
        {
            int[] unsortedArray = { 9, 8, 3, 4, 7, 5, 0, 1, 2, 6 };
            int[] sortedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] resultArray = InsertionSort.InsertionSort.Sort(unsortedArray);
            for (int indexToCompare = 0; indexToCompare < unsortedArray.Length; indexToCompare++)
            {
                Assert.AreEqual(sortedArray[indexToCompare], resultArray[indexToCompare]);
            }
        }

        [TestMethod]
        public void SortUnsortedArrayWithEqualElements()
        {
            int[] unsortedArray = { 9, 8, 3, 4, 7, 5, 8, 0, 1, 8, 6, 2 };
            int[] sortedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 8, 8, 9 };
            var resultArray = InsertionSort.InsertionSort.Sort(unsortedArray);
            for (int indexToCompare = 0; indexToCompare < unsortedArray.Length; indexToCompare++)
            {
                Assert.AreEqual(sortedArray[indexToCompare], resultArray[indexToCompare]);
            }
        }

        [TestMethod]
        public void SortSortedArray()
        {
            int[] unsortedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] sortedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var resultArray = InsertionSort.InsertionSort.Sort(unsortedArray);
            for (int indexToCompare = 0; indexToCompare < unsortedArray.Length; indexToCompare++)
            {
                Assert.AreEqual(sortedArray[indexToCompare], resultArray[indexToCompare]);
            }
        }

        [TestMethod]
        public void SortNullArray()
        {
            int[] nullArray = null;
            var resultArray = InsertionSort.InsertionSort.Sort(nullArray);
            Assert.IsNull(resultArray);
        }

        [TestMethod]
        public void SortEmptyArray()
        {
            int[] emptyArray = { };
            var resultArray = InsertionSort.InsertionSort.Sort(emptyArray);
            Assert.AreEqual(emptyArray, resultArray);
        }

        [TestMethod]
        public void SortSortedOneItemArray()
        {
            int[] unsortedArray = { 8 };
            int[] sortedArray = { 8 };
            var resultArray = InsertionSort.InsertionSort.Sort(unsortedArray);
            for (int indexToCompare = 0; indexToCompare < unsortedArray.Length; indexToCompare++)
            {
                Assert.AreEqual(sortedArray[indexToCompare], resultArray[indexToCompare]);
            }
        }

        [TestMethod]
        public void SortUnsortedTwoItemArray()
        {
            int[] unsortedArray = { 8, 0 };
            int[] sortedArray = { 0, 8 };
            var resultArray = InsertionSort.InsertionSort.Sort(unsortedArray);
            for (int indexToCompare = 0; indexToCompare < unsortedArray.Length; indexToCompare++)
            {
                Assert.AreEqual(sortedArray[indexToCompare], resultArray[indexToCompare]);
            }
        }
    }
}
