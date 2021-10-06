using System;

namespace SelectionSort
{
    public class SelectionSort2
    {

        public static void Main(string[] args)
        {
            Console.WriteLine($"[{string.Join(",", Sort(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }))}]");
        }

        public static int[] Sort(int[] unSortedArray)
        {
            if (unSortedArray == null || unSortedArray.Length < 1)
            {
                return unSortedArray;
            }
            return Selection(unSortedArray, 0);
        }

        private static int[] Selection(int[] unSortedArray, int currentIndex)
        {

            if (currentIndex == unSortedArray.Length - 1)
            {
                return unSortedArray;
            }

            int indexToSave = currentIndex;
            int minIndex = currentIndex;

            while (currentIndex < unSortedArray.Length - 1)
            {
                if (unSortedArray[minIndex] > unSortedArray[currentIndex + 1])
                {
                    minIndex = currentIndex + 1;
                }

                currentIndex++;
            }

            if (indexToSave != minIndex)
            {
                unSortedArray[indexToSave] ^= unSortedArray[minIndex];
                unSortedArray[minIndex] ^= unSortedArray[indexToSave];
                unSortedArray[indexToSave] ^= unSortedArray[minIndex];
            }

            return Selection(unSortedArray, ++indexToSave);


        }
    }
}

