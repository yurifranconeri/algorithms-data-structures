using System;

namespace InsertionSort
{
    public class InsertionSort
    {
        public static int[] Sort(int[] unsortedArray)
        {
            if (unsortedArray == null || unsortedArray.Length < 2)
            {
                return unsortedArray;
            }
            int currentIndex = 1;
            return InsertionSorting(unsortedArray, currentIndex);
        }

        private static int[] InsertionSorting(int[] unsortedArray, int currentIndex)
        {
            if (currentIndex > unsortedArray.Length - 1)
            {
                return unsortedArray;
            }
            var previousIndex = currentIndex - 1;
            if (unsortedArray[currentIndex] > unsortedArray[previousIndex])
            {
                return InsertionSorting(unsortedArray, currentIndex + 1);
            }
            var valueToChange = unsortedArray[currentIndex];

            while (previousIndex >= 0 && unsortedArray[previousIndex] > valueToChange)
            {
                unsortedArray[previousIndex + 1] = unsortedArray[previousIndex];
                previousIndex--;
            }

            unsortedArray[++previousIndex] = valueToChange;

            return InsertionSorting(unsortedArray, ++currentIndex);
        }
    }
}
