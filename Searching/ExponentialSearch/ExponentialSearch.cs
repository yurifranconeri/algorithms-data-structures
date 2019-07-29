using System;

namespace ExponentialSearch
{
    public class ExponentialSearch
    {
        public static int Search(int[] values, int valueToFind)
        {
            if(values==null || values.Length < 1)
            {
                return -1;
            }
            if (values[0] == valueToFind)
            {
                return 0;
            }
            if (values[values.Length - 1] < valueToFind)
            {
                return -1;
            }
            var index = 1;
            return ExponentialSearching(values, valueToFind, index);
        }

        private static int ExponentialSearching(int[] values, int valueToFind, int index)
        {                        
            if (values[index] == valueToFind)
            {
                return index;
            }
            if (values[index] > valueToFind)
            {
                var startIndex = index / 2;
                return BinarySearching(values, valueToFind, startIndex, index);
            }
            if (index == values.Length - 1)
            {
                return -1;
            }
            if (values[index] < valueToFind)
            {                
                index = Math.Min(index * 2, values.Length-1);
                return ExponentialSearching(values, valueToFind, index);
            }           

            return -1;
        }

        private static int BinarySearching(int[] values, int valueToFind, int startIndex, int finalIndex)
        {
            var midValue = startIndex + (finalIndex - startIndex);
            if (finalIndex <= startIndex)
            {
                return -1;
            }
            if (values[midValue] == valueToFind)
            {
                return midValue;
            }
            if (values[midValue] > valueToFind)
            {
                return BinarySearching(values, valueToFind, startIndex, midValue - 1);
            }
            if (values[midValue] < valueToFind)
            {
                return BinarySearching(values, valueToFind, midValue + 1, finalIndex);
            }

            return -1;
        }
    }
}
