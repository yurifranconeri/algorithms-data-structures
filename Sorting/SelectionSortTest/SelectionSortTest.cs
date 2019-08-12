using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SelectionSortTest
{
    [TestClass]
    public class SelectionSortTest
    {
        [TestMethod]
        public void SelectionSortArrayForUnsortedArray()
        {
            int[] unSortedArray = { 3, 4, 1, 5, 0, 2 };
            int[] sortedArray = { 0, 1, 2, 3, 4, 5 };

            int[] resultArray = SelectionSort.SelectionSort.Sort(unSortedArray);

            for (int i = 0; i < resultArray.Length; i++)
            {
                Assert.AreEqual(resultArray[i], sortedArray[i]);
            }
            
        }

        [TestMethod]
        public void SelectionSortArrayForSortedArray()
        {
            int[] unSortedArray = { 0, 1, 2, 3, 4, 5 };
            int[] sortedArray = { 0, 1, 2, 3, 4, 5 };

            int[] resultArray = SelectionSort.SelectionSort.Sort(unSortedArray);

            for (int i = 0; i < resultArray.Length; i++)
            {
                Assert.AreEqual(resultArray[i], sortedArray[i]);
            }
        }

        [TestMethod]
        public void SortUnsortedArrayWithEqualElements()
        {
            int[] unsortedArray = { 9, 8, 3, 4, 7, 5, 8, 0, 1, 8, 6, 2 };
            int[] sortedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 8, 8, 9 };
            var resultArray = SelectionSort.SelectionSort.Sort(unsortedArray);
            for (int indexToCompare = 0; indexToCompare < unsortedArray.Length; indexToCompare++)
            {
                Assert.AreEqual(sortedArray[indexToCompare], resultArray[indexToCompare]);
            }
        }

        [TestMethod]
        public void SelectionSortArrayForOneItemArray()
        {
            int[] unSortedArray = { 0 };
            int[] sortedArray = { 0 };

            int[] resultArray = SelectionSort.SelectionSort.Sort(unSortedArray);

            for (int i = 0; i < resultArray.Length; i++)
            {
                Assert.AreEqual(resultArray[i], sortedArray[i]);
            }
        }


        [TestMethod]
        public void SelectionSortArrayForTwoItemsArray()
        {
            int[] unSortedArray = { 1, 0 };
            int[] sortedArray = { 0, 1};

            int[] resultArray = SelectionSort.SelectionSort.Sort(unSortedArray);

            for (int i = 0; i < resultArray.Length; i++)
            {
                Assert.AreEqual(resultArray[i], sortedArray[i]);
            }
        }

        [TestMethod]
        public void SelectionSortNullArray()
        {
            int[] resultArray = SelectionSort.SelectionSort.Sort(null);

            Assert.IsNull(resultArray);
        }

        [TestMethod]
        public void SelectionSortEmptyArray()
        {
            int[] unSortedArray = {};
            int[] resultArray = SelectionSort.SelectionSort.Sort(unSortedArray);

            Assert.AreEqual(resultArray, unSortedArray);
        }
    }
}
