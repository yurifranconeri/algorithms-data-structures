using System;
using Xunit;
using QuickSort;

namespace QuickSortTest
{
    public class QuickSortTest
    {
        [Fact]
        public void QuickSortUnSortedArray()
        {
            int[] unSortedArray = { 3, 4, 1, 5, 0, 2 };
            int[] sortedArray = { 0, 1, 2, 3, 4, 5 };

            int[] resultArray = QuickSort.QuickSort.Sort(unSortedArray);

            for (int i = 0; i < resultArray.Length; i++)
            {
                Assert.Equal(resultArray[i], sortedArray[i]);
            }
        }

        [Fact]
        public void QuickSortArrayForUnsortedArray()
        {
            int[] unSortedArray = { 3, 4, 1, 5, 0, 2 };
            int[] sortedArray = { 0, 1, 2, 3, 4, 5 };

            int[] resultArray = QuickSort.QuickSort.Sort(unSortedArray);

            for (int i = 0; i < resultArray.Length; i++)
            {
                Assert.Equal(resultArray[i], sortedArray[i]);
            }

        }

        [Fact]
        public void QuickSortArrayForSortedArray()
        {
            int[] unSortedArray = { 0, 1, 2, 3, 4, 5 };
            int[] sortedArray = { 0, 1, 2, 3, 4, 5 };

            int[] resultArray = QuickSort.QuickSort.Sort(unSortedArray);

            for (int i = 0; i < resultArray.Length; i++)
            {
                Assert.Equal(resultArray[i], sortedArray[i]);
            }
        }

        [Fact]
        public void SortUnsortedArrayWithEqualElements()
        {
            int[] unsortedArray = { 9, 8, 3, 4, 7, 5, 8, 0, 1, 8, 6, 2 };
            int[] sortedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 8, 8, 9 };
            var resultArray = QuickSort.QuickSort.Sort(unsortedArray);
            for (int indexToCompare = 0; indexToCompare < unsortedArray.Length; indexToCompare++)
            {
                Assert.Equal(sortedArray[indexToCompare], resultArray[indexToCompare]);
            }
        }

        [Fact]
        public void QuickSortArrayForOneItemArray()
        {
            int[] unSortedArray = { 0 };
            int[] sortedArray = { 0 };

            int[] resultArray = QuickSort.QuickSort.Sort(unSortedArray);

            for (int i = 0; i < resultArray.Length; i++)
            {
                Assert.Equal(resultArray[i], sortedArray[i]);
            }
        }


        [Fact]
        public void QuickSortArrayForTwoItemsArray()
        {
            int[] unSortedArray = { 1, 0 };
            int[] sortedArray = { 0, 1 };

            int[] resultArray = QuickSort.QuickSort.Sort(unSortedArray);

            for (int i = 0; i < resultArray.Length; i++)
            {
                Assert.Equal(resultArray[i], sortedArray[i]);
            }
        }

        [Fact]
        public void QuickSortNullArray()
        {
            int[] resultArray = QuickSort.QuickSort.Sort(null);

            Assert.Null(resultArray);
        }

        [Fact]
        public void QuickSortEmptyArray()
        {
            int[] unSortedArray = { };
            int[] resultArray = QuickSort.QuickSort.Sort(unSortedArray);

            Assert.Equal(resultArray, unSortedArray);
        }
    }
}
