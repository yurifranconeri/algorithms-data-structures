using System;

namespace BinarySearch
{
    public class BinarySearch
    {
        public static int Search(int[] values, int valueToFind)
        {
            if (values == null || values.Length < 1)
                return -1;

            if (values.Length == 1)
            {
                return values[0] == valueToFind ? 0 : -1;
            }
            return BinarySearching(values, 0, values.Length - 1, valueToFind);
        }

        private static int BinarySearching(int[] values, int leftIndex, int rightIndex, int valueToFind)
        {
            if (rightIndex >= leftIndex)
            {
                var midIndex = leftIndex + (rightIndex - leftIndex) / 2;

                if (values[midIndex] == valueToFind)
                {
                    return midIndex;
                }
                if (values[midIndex] > valueToFind)
                {
                    return BinarySearching(values, leftIndex, midIndex - 1, valueToFind);
                }
                if (values[midIndex] < valueToFind)
                {
                    return BinarySearching(values, midIndex + 1, rightIndex, valueToFind);
                }                
            }
            return -1;
        }
    }
}
