using System;

namespace SelectionSort
{
    public class SelectionSort
    {
        public static int[] Sort(int[] unSortedArray)
        {
            if(unSortedArray==null || unSortedArray.Length < 1)
            {
                return unSortedArray;
            }
            int currentIndex = 0;
            int[] sortedArray = new int[unSortedArray.Length];
            return Selection(unSortedArray, currentIndex);
        }

        private static int[] Selection(int[] unSortedArray, int currentIndex)
        {
            if (currentIndex >= unSortedArray.Length)
            {
                return unSortedArray;
            }

            int minIndex=currentIndex;
            for (int i = currentIndex; i < unSortedArray.Length; i++)
            {
                if (unSortedArray[i] < unSortedArray[minIndex])
                {
                    minIndex = i;
                }
            }
            var temp = unSortedArray[currentIndex];
            unSortedArray[currentIndex] = unSortedArray[minIndex];
            unSortedArray[minIndex] = temp;
            
            currentIndex++;
            return Selection(unSortedArray, currentIndex);
        }
    }
}
