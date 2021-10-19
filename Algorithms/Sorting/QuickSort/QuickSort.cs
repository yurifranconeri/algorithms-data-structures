using System;

namespace QuickSort
{
    public static class QuickSort
    {
        public static int[] Sort(int[] unsortedArray)
        {
            if (unsortedArray == null || unsortedArray.Length < 2)
            {
                return unsortedArray;
            }

            QuickSorting(unsortedArray, 0, unsortedArray.Length - 1);

            return unsortedArray;
        }

        private static void QuickSorting(int[] array, int start, int end)
        {
            if (start < end)
            {
                var pivot = Partition(array, start, end);
                QuickSorting(array, start, pivot - 1);
                QuickSorting(array, pivot + 1, end);
            }
        }

        private static int Partition(int[] array, int start, int end)
        {
            var pivotValue = array[end];
            int pseudoPivotIndex = start;
            for (int j = start; j < end; j++)
            {
                if (array[j] <= pivotValue)
                {
                    var temp = array[j];
                    array[j] = array[pseudoPivotIndex];
                    array[pseudoPivotIndex] = temp;
                    pseudoPivotIndex++;
                }
            }

            var aux = array[pseudoPivotIndex];
            array[pseudoPivotIndex] = array[end];
            array[end] = aux;

            return pseudoPivotIndex;
        }
    }
}
