using System;

namespace BubbleSort
{
    public class BubbleSort
    {
        public static int[] Sort(int[] unsortedArray)
        {
            if (unsortedArray == null || unsortedArray.Length < 2)
            {
                return unsortedArray;
            }
            return BubbleSorting(unsortedArray, 0, unsortedArray.Length);
        }

        private static int[] BubbleSorting(int[] unsortedArray, int currentIndex, int maxLengthToCheck)
        {
            if (maxLengthToCheck < 1)
            {
                return unsortedArray;
            }
            if (currentIndex > unsortedArray.Length-2)
            {
                return BubbleSorting(unsortedArray, 0, --maxLengthToCheck);
            }
            var nextIndex = currentIndex + 1;
            if (unsortedArray[currentIndex] > unsortedArray[nextIndex])
            {
                var temp = unsortedArray[currentIndex];
                unsortedArray[currentIndex] = unsortedArray[nextIndex];
                unsortedArray[nextIndex] = temp;
            }
            return BubbleSorting(unsortedArray, currentIndex+1, maxLengthToCheck);
        }
    }
}
