using System;

namespace InsertionSort
{
    public class InsertionSort2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"[{string.Join(",", Sort(new int[] { 1, 0, 4, 3 }))}]");
            Console.WriteLine($"[{string.Join(",", Sort(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }))}]");
            Console.WriteLine($"[{string.Join(",", Sort(new int[] { 0, 8, 7, 6, 1, 4, 1, 2, 1, 0 }))}]");
        }

        public static int[] Sort(int[] unsortedArray)
        {
            if (unsortedArray == null || unsortedArray.Length < 2)
            {
                return unsortedArray;
            }

            return InsertionSorting(unsortedArray, 1);
        }

        private static int[] InsertionSorting(int[] unsortedArray, int currentIndex)
        {
            if (currentIndex == unsortedArray.Length)
            {
                return unsortedArray;
            }

            if (unsortedArray[currentIndex] >= unsortedArray[currentIndex - 1])
            {
                return InsertionSorting(unsortedArray, ++currentIndex);
            }

            var valueToSwap = unsortedArray[currentIndex];
            var indexToSwap = currentIndex;

            while (currentIndex >= 1 && valueToSwap < unsortedArray[currentIndex - 1])
            {
                unsortedArray[currentIndex] = unsortedArray[currentIndex - 1];
                currentIndex--;
            }

            unsortedArray[currentIndex] = valueToSwap;

            return InsertionSorting(unsortedArray, ++indexToSwap);

        }
    }
}
